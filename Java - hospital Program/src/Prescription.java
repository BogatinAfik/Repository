
public class Prescription extends Note {

	private boolean pharmSupply;
	private int drugId;
	
	public Prescription (Note n, boolean pharmSupply, int drugId) {
		super(n.getPatientId(), n.getNurseId(), n.getBloodPressure(), n.getTemperature(), n.getConditionLevel());
		this.pharmSupply = pharmSupply;
		this.drugId = drugId;
	}
	
	protected void setPharmSupply(boolean pharmSupply) {
		this.pharmSupply = pharmSupply;
	}
	
	protected int getDrugId(){
		return drugId;
	}
}