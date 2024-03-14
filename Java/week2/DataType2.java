package week2;

import java.awt.desktop.PrintFilesEvent;

public class DataType2 {
	public static void main(String[] args) {
		// 실수값 저장
		float	fValue = 3.14f;
		double	dValue = 3.14;
		System.out.println("fValue = " + fValue);
		System.out.println("dValue = " + dValue);
		
		// 정밀도 테스트
		fValue = 0.1234567890123456789f;
		dValue = 0.1234567890123456789;
		System.out.println("fValue = " + fValue);
		System.out.println("dValue = " + dValue);
		// 과거에는 사양 꾸졌음 => 데이터 크기에 맞게 맞춰서 썼는데, 요새는 워낙 사양이 좋아져서 그냥 double만 써도 무방함.
		
		// e 사용하기
		int		iData = 4500000;
		float	fData = 3e7f; // e7 = 10^7
		double	dData1 = 3e7;
		double 	dData2 = 3e-7; // e-7 = 10^-7
		System.out.println("iData = " + iData);
		System.out.println("fData = " + fData);
		System.out.println("dData1 = " + dData1); // 리터럴 값에 e를 넣어도 출력이 E로 잘 됨.
		System.out.println("dData2 = " + dData2);
		
		// 프린트 포맷
		// %f: 실수
		System.out.println();
		
		System.out.printf("iData = %d\n", iData);
		System.out.printf("fData = %f\n", fData);
		System.out.printf("dData1 = %f\n", dData1); 
		System.out.printf("dData2 = %.7f\n", dData2); // %f가 소수점 아래 6째 자리 까지만 출력(기본)해줘서 3이 안보임.
		
		System.out.println();
		
		System.out.printf("iData = %d\n", iData);
		System.out.printf("fData = %.4f\n", fData);
		System.out.printf("dData1 = %.2f\n", dData1); 
		System.out.printf("dData2 = %10.8f\n", dData2); // 10.8 => 총 10자리 표현할거고, 소수점 아래 8자리 표현하겠다. 전체 자리 10중에는 소수점도 포함해서 10자리임.
		
	}
}
