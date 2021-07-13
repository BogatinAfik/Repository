import java.util.Vector;

public class Pharmacist extends Worker implements Runnable {

	public Pharmacist(PriorityQueue <Patient> senDocLine, BoundedQueue <Patient> junDocLine, 
			UnboundedQueue <Patient> pharmLine, UnboundedQueue <Patient> nurseLine, UnboundedQueue <Patient> managerData, Object key, Vector <Patient> pTracker) {

		super(senDocLine, junDocLine, pharmLine, nurseLine, managerData, key, pTracker); //does he need a name??
	}

	//treats patient
	public void treatPatient(Patient p) {
		try {
			Thread.sleep(randomIntInRange(1,5)*1000);
		} catch (InterruptedException e) {}	
		p.getPrescription().setPharmSupply(true);
		pTracker.remove(p); //patient left the ER
		if (pTracker.size()== 0) {
			synchronized(key) {
				key.notifyAll(); //notifies manager when all patients have been treated
			}
		}
	}

	protected void work() {
		while(!pTracker.isEmpty() || Manager.closingTime != 0) {
				Patient p = pharmLine.extract();
				if (p != null) {
					treatPatient(p);
			}
		}
	}

	public void run() {
		work();
		System.out.println("pharm dead");	
	}
}

