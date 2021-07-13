
public class Note {
	private int treatType;
	private int index; 
	private int patientId;
	private double temperature;
	private int conditionLevel;
	private int bloodPressure;
	private int docId;
	private int nurseId;
	private static int noteCounter;

	//creates note with all relevant data
	public Note  (int patientId, int nurseId, int bloodPressure, double temperature, int conditionLevel) {
		this.patientId = patientId;
		this.nurseId = nurseId;
		this.bloodPressure = bloodPressure;
		this.temperature = temperature;
		this.conditionLevel = conditionLevel;
		noteCounter++;
		index = noteCounter;
	}
	
	protected void setIndex(int index) {
		this.index = index;
	}
	
	protected void setDocId(int docId) {
		this.docId = docId;
	}
	
	protected void setTreatType(int treatType) {
		this.treatType = treatType;
	}
	
	protected int getPatientId() {
		return this.patientId;
	}
	
	protected int getNurseId() {
		return this.nurseId;
	}
	
	public int getDocId() {
		return this.docId;
	}
	
	
	protected int getBloodPressure() {
		return this.bloodPressure;
	}
	
	protected double getTemperature() {
		return this.temperature;
	}
	
	protected int getConditionLevel() {
		return this.conditionLevel;
	}
	
	protected int getTreatType() {
		return treatType;
	}

}