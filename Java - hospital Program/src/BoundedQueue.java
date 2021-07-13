import java.util.Vector;

public class BoundedQueue <T>{
	private Vector <T> queue;
	private int maxSize;
	
	public BoundedQueue(int maxSize) 
	{
	    queue = new Vector <T>();
	    this.maxSize=maxSize;
	}
	
	public synchronized void insert(T item) {
	    while(queue.size()>=maxSize)
			try {
				wait();
			} catch (InterruptedException e) {
				
			}

	    queue.add(item);
	    notifyAll();  
	}
	    
	 public synchronized T extract()  {
	     while (queue.isEmpty())
			try {
				wait();
			} catch (InterruptedException e) {
			}
	     T item = queue.elementAt(0);
	     queue.remove(item);
	     notifyAll();
	     return item;    
	}

	 public synchronized Vector <T> getBoundedQueue() { 
			return queue;
		}

}
