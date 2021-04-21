package learningMule;
public class example {

	public static String TellMeYourFullName(String fname, String lname) {
		return "First Name: "+fname+", Last Name: "+lname;
	}
	
	
	String fname, lname; 
	public example(String fname, String lname) {
		this.fname=fname;
		this.lname=lname;
	}
	
	public String FullDetails(int Age) {
		return "First Name: "+fname+ ", Last Name: "+lname + ", Age: "+Age;
	}
	
}
