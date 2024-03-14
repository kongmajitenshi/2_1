package week2;

public class DataType3 {
	public static void main(String[] args) {
		char	cData1 = 'A'; // 문자 직접 저장.
		char	cData2 = 65; // 10진수로 저장. 유니코드 65 = 'A' 
		char	cData3 = '\u0041'; // 16진수로 저장. 
		/* 역슬래시u 는 16진수로 저장하겠다~ 하는 표현. 0000 0000 0100 0001 (2)=> 65 (10)*/ 
		System.out.println("cData1 = " + cData1);
		System.out.println("cData2 = " + cData2);
		System.out.println("cData3 = " + cData3);
		
		char 	cData4 = '가';
		char 	cData5 = 44032;
		char 	cData6 = '\uac00';
		System.out.println("cData4 = " + cData4);
		System.out.println("cData5 = " + cData5);
		System.out.println("cData6 = " + cData6);
		
		/*
		 * char타입 변수의
		 * 유니코드 값을 알고싶다면
		 * int 타입 변수에 저장해서 확인
		 */
		
		int		cData7 = 'B';
		int		cData8 = '하';
		int		cData9 = '&';
		System.out.println("cData7 = " + cData7);
		System.out.println("cData8 = " + cData8);
		System.out.println("cData9 = " + cData9);
		
		int cData10 = cData7 + cData9;
		System.out.println("cData7 + cData9 = " + cData10);

		char cData11 = (char)(cData7 + cData9);
		System.out.println("cData7 + cData9 = " + cData11);
		
	}
}

