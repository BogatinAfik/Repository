import java.util.Vector;

public class Patient implements Comparable <Patient>, Runnable{

	private String firstName;
	private String lastName;
	private int age;
	private int height;
	private int weight;
	private int id;
	private int arrivalTime;
	protected UnboundedQueue <Patient> nurseLine; 
	protected Note note;
	protected Prescription prescription;
	protected Vector <Patient> pTracker;
	

	public Patient (String firstName, String lastName, int age, int height,
			int weight, int id, int arrivalTime, UnboundedQueue <Patient> nurseLine, Vector <Patient> pTracker) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.age = age;
		this.height = height;
		this.weight = weight;
		this.id = id;
		this.arrivalTime = arrivalTime;
		this.nurseLine = nurseLine;
		this.pTracker = pTracker;
		
	}

	public int compareTo(Patient p) {
		if (this.getNote().getConditionLevel() < p.getNote().getConditionLevel())
			return -1; //"My" condition level is lower than p's
		if (this.getNote().getConditionLevel() > p.getNote().getConditionLevel())
			return 1; //P's condition level is higher than "mine"
		else
			return 0;
	}

	public int getId() {
		return this.id;
	}

	public int getAge() {
		return this.age;
	}

	public int getHeight() {
		return this.height;
	}

	public int getWeight() {
		return this.weight;
	}

	public int getArrivalTime() {
		return this.arrivalTime;
	}

	protected void setNote(Note n) {
		this.note = n;
	}

	protected void setPrescription(Prescription p) {
		this.prescription = p;
	}

	protected Note getNote() {
		return this.note;
	}

	protected Prescription getPrescription() {
		return prescription;
	}

	public void run() {
		//goes into nurse's line if it's arrival time is appropriate (the ER isn't closing before it)
		if (arrivalTime <= Manager.closingTime) { 
		try {
			Thread.sleep(arrivalTime*1000);
		} catch (InterruptedException e) {
		}		
			nurseLine.insert(this); //adds self to nurse's queue
			pTracker.add(this); //adds self to patient tracker, officially inside the ER 
		}
		
	}

}
