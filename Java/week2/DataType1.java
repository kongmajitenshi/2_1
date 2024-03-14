package week2;

public class DataType1 {
	public static void main(String[] args) {
		int 	iData = 65;
		byte 	bData = 65;
		short 	sData = 65;
		long 	lData = 65;
		float 	fData = 65.12f;
		double 	dData = 65.12d;
		char	cData = 65;
		boolean	boolData = true;
		
		System.out.println("iData = " + iData);
		System.out.println("bData = " + bData);
		System.out.println("sData = " + sData);
		System.out.println("lData = " + lData);
		System.out.println("fData = " + fData);
		System.out.println("dData = " + dData);
		System.out.println("cData = " + cData); // 출력값은 'A' 임. 아스키코드(유니코드의 맨 앞 부분은 아스키코드가 그대로 들어가있음)값 65가 A이기 때문.
		System.out.println("boolData = " + boolData);
		// float fData = 65.12; // 실수 리터럴의 기본값은 double임. 그래서 float로 저장하고 싶다면 리터럴 뒤에 f를 붙여줘야함.
		
	}
}
