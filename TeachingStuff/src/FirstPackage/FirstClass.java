package FirstPackage;


public class FirstClass {

	static int integer;
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		int integer = 76*6;
		long longInteger = Long.MAX_VALUE;
		short shortInteger = 32+76;
		boolean bool = true;
		bool = false;
		char character = Character.MAX_VALUE;
		//char characterA = 'Z';
		float floatNumbers= 3/4;
		double doubles = 75.9-0.9;
		byte bytes = Byte.MAX_VALUE;
		integer = (int)doubles;
		
		//int a_Number = characterA;
		//integer = FirstClass.integer + FirstClass.integer;
		
		
		//System.out.println(characterA);
		System.out.println(longInteger);
		System.out.println(integer);
		//System.out.println(a_Number);
		System.out.println(doubles);
		System.out.println(floatNumbers);
		System.out.println((int)character);
		System.out.println(bool);
		System.out.println(bytes);
		System.out.println(shortInteger);

	}

}
