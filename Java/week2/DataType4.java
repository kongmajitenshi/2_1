package week2;

public class DataType4 {
	public static void main(String[] args) {
//		byte	bData = 128; 1byte 자료형 = -128~127 까지.
//		char	cData = -90; char은 음수 없음.
//		float	fData = 3.14; default 값이 double 이므로 f를 붙여줘야함.
//		long	lData = 10000000000; 정수 default 값이 int임. 숫자 뒤에 'l'을 붙여줘야 long 타입으로 인식함.
//		boolean	boolD = 10; 기존 값. boolean 타입은 true, false 만 있음. 보통 0=false, 0이 아님=true 으로 쓰긴 함. 자바에선 안됨.
		
		byte	bData = 127;
		char	cData = 90;
		float	fData = 3.14f;
		long	lData = 10000000000l;
		boolean	boolD = true;
		
		
		System.out.println("bData = " + bData);
		System.out.println("cData = " + cData);
		System.out.println("fData = " + fData);
		System.out.println("lData = " + lData);
		System.out.println("boolD = " + boolD);
	}
}
