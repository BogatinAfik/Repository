import java.util.Vector;

public class Nurse extends Worker implements Runnable{

	public Nurse (PriorityQueue <Patient> senDocLine, BoundedQueue <Patient> junDocLine, 
			UnboundedQueue <Patient> pharmLine, UnboundedQueue <Patient> nurseLine, UnboundedQueue <Patient> managerData, Object key, Vector <Patient> pTracker) {

		super(senDocLine, junDocLine, pharmLine, nurseLine, managerData, key, pTracker);
	}


	//treats patient 
	public void treatPatient(Patient p) {
		try {
			Thread.sleep(randomIntInRange(0,4)*1000);
		} catch (InterruptedException e) {}
		int bloodPressure = calcBloodPressure();
		double temperature = calcTemperature();
		int conditionLevel = calcConditionLevel(p, bloodPressure, temperature);
		//creates note for patient
		Note n = new Note (p.getId(), this.id, bloodPressure, temperature, conditionLevel);
		p.setNote(n);

	}

	//calculates blood pressure
	public int calcBloodPressure() {
		double random = Math.random();
		if (random < 0.8) {
			return randomIntInRange(90, 140);	
		}
		if (random == 0.8) {
			return randomIntInRange(0, 90);
		}
		else {
			return randomIntInRange(140, 300);
		}
	}

	//calculates temperature
	public double calcTemperature() {
		double random = Math.random();
		if (random < 0.7) {
			return randomDoubleInRange(38, 39);	
		}
		if (random >= 0.7 || random < 0.9) {
			return randomDoubleInRange(39, 40);
		}
		else {
			return randomDoubleInRange(34, 38);
		}
	}

	//calculates condition level
	public int calcConditionLevel(Patient p, int bloodPressure, double temperature) {
		int level = 0;
		if (temperature > 38 && temperature < 39)
			level = 0;
		else 
			level = 3;

		if (bloodPressure > 90 && bloodPressure < 140) 
			level += 4;
		else
			level += 2;
		level += (p.getWeight()/p.getHeight())*4;

		if (level > 10)
			level = 10;

		if (level < 6 && Math.random() == 0.1) 
			level = -1;

		return level;
	}

	//takes patient from line and treats
	protected void work() {
		while(!pTracker.isEmpty() || Manager.closingTime != 0) {
			Patient p = nurseLine.extract();
			if(p!=null) {
				treatPatient(p);	
				nextTreatment(p);
			} 
		}
	}

	//moves patient to next treatment by condition level
	private void nextTreatment(Patient p) {
		if (p.getNote().getConditionLevel() < 6) {
			junDocLine.insert(p);
		}
		else {
			senDocLine.insert(p);
		}

	}

	public void run() {
		work();
		System.out.println("nurse dead");	
	}


}
