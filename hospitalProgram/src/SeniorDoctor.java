import java.util.Vector;

public class SeniorDoctor extends Worker implements Runnable {

	public SeniorDoctor (PriorityQueue <Patient> senDocLine, BoundedQueue <Patient> junDocLine, 
			UnboundedQueue <Patient> pharmLine, UnboundedQueue <Patient> nurseLine, UnboundedQueue <Patient> managerData, Object key, Vector <Patient> pTracker) {
		super(senDocLine, junDocLine, pharmLine, nurseLine, managerData, key, pTracker);
	}

	//treats patient
	public void treatPatient(Patient p) {
		try {
			Thread.sleep(6000);
		} catch (InterruptedException e) {}	
		p.getNote().setDocId(this.id); //sets doc ID
		p.getNote().setTreatType(randomIntInRange(0, 6)+p.getNote().getConditionLevel()); 
		managerData.insert(p); //inserts into manager's data
		if(Math.random() <= 0.5) { //needs prescription
			Prescription drug = new Prescription (p.getNote(), false, randomIntInRange(0, 6)+p.getNote().getTreatType());
			p.setPrescription(drug);
			pharmLine.insert(p);
		} else {
			pTracker.remove(p); //patient left the ER
			if (pTracker.size()== 0) {
				synchronized(key) {
					key.notifyAll(); //notifies manager when all patients have been treated
				}
			}
		}
	}

	protected void work() {
		while(!pTracker.isEmpty() || Manager.closingTime != 0) {
				Patient p = senDocLine.extract();
				if(p!=null) {
					treatPatient(p);
			}
		}
	}

	public void run() {
		work();
		System.out.println("senior dead");	

	}
}