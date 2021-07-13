import java.util.Vector;

abstract public class Worker {
	protected static int idCounter;
	protected int id;
	protected PriorityQueue <Patient> senDocLine;
	protected BoundedQueue <Patient> junDocLine;
	protected UnboundedQueue <Patient> pharmLine;
	protected UnboundedQueue <Patient> nurseLine;
	protected UnboundedQueue <Patient> managerData;
	protected Vector <Patient> pTracker;
	protected Object key;

	
	public Worker(PriorityQueue <Patient> senDocLine, BoundedQueue <Patient> junDocLine, 
			UnboundedQueue <Patient> pharmLine, UnboundedQueue <Patient> nurseLine, UnboundedQueue <Patient> managerData, Object key, Vector <Patient> pTracker) {
		
		idCounter++;
		this.id = idCounter;
		this.senDocLine = senDocLine; 
		this.junDocLine = junDocLine; 
		this.pharmLine = pharmLine; 
		this.nurseLine = nurseLine;
		this.managerData = managerData;
		this.pTracker = pTracker;
		this.key = key;
		
	}


	abstract void treatPatient(Patient p);
	
	abstract void work();

	//returns random integer for worker calculations
	public static int randomIntInRange(int min, int max) {
		int rand = (int) (Math.random()*((max-min)+1)+min);
		return rand;
		
	}

	//returns random double for worker calculations
	public static double randomDoubleInRange(double min, double max) {
		double rand =  (Math.random()*((max-min)+1))+min;
		return rand;
		
	}
}
