import java.util.Vector;

public class Manager implements Runnable {
	public static int closingTime;
	protected PriorityQueue <Patient> senDocLine;
	protected BoundedQueue <Patient> junDocLine;
	protected UnboundedQueue <Patient> pharmLine;
	protected UnboundedQueue <Patient> nurseLine;
	protected  UnboundedQueue <Patient> managerData;
	protected Vector <Patient> pTracker;
	protected Object key;
	protected int numOfNurses;

	public Manager (int closingTime, PriorityQueue <Patient> senDocLine, BoundedQueue <Patient> junDocLine, 
			UnboundedQueue <Patient> pharmLine, UnboundedQueue <Patient> nurseLine, UnboundedQueue <Patient> managerData, Object key, int numOfNurses, Vector <Patient> pTracker){

		this.closingTime = closingTime;
		this.senDocLine = senDocLine;
		this.junDocLine = junDocLine;
		this.pharmLine = pharmLine;
		this.nurseLine = nurseLine;
		this.managerData = managerData;
		this.pTracker = pTracker;
		this.key = key;
		this.numOfNurses = numOfNurses;
	}

	public static int getTime() {
		return closingTime;
	}

	public void run() {
		try {
			Thread.sleep(closingTime*1000);
		} catch (InterruptedException e) {}	
		closingTime = 0; //ends work day 
		synchronized(key) { 
			while(!pTracker.isEmpty()) { //waits for all patients to leave ER
				try {
					key.wait();
				} catch (InterruptedException e) {}	 
			}
		}
		stopWorkers();
		setData(); //sets data in database
		System.out.println("manager dead");	
		}

	//inserts nulls into each worker's queue in order to make the stop working
	private void stopWorkers() {
		for(int i=0;i<numOfNurses;i++) 
			nurseLine.insert(null);
		for(int i = 0; i<3;i++)
			junDocLine.insert(null);
		senDocLine.insert(null);
		senDocLine.insert(null);
		pharmLine.insert(null);
		pharmLine.insert(null);		
	}

	//creates and sets data in database
	private void setData() { 
		Database patientData = new Database();
		patientData.addTable("Patient");

		for (int i = 0; i < managerData.getUnboundQueue().size(); i++) {
			int ID = managerData.getUnboundQueue().elementAt(i).getId();
			int Age = managerData.getUnboundQueue().elementAt(i).getAge();
			int Prescription = 0;
			if (managerData.getUnboundQueue().elementAt(i).prescription != null) { //if there is a prescription
				Prescription = managerData.getUnboundQueue().elementAt(i).getPrescription().getDrugId();
			}
			int docId = managerData.getUnboundQueue().elementAt(i).getNote().getDocId();
			int treatType =  managerData.getUnboundQueue().elementAt(i).getNote().getTreatType();
			patientData.insert("Patient", ID, Age, Prescription, docId, treatType);
		}
	}




}
