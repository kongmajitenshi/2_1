package week2;

public class Print4 {
	public static void main(String[] args) {
		System.out.println(23+18);
		System.out.println("23 + 18 = " + (23+18));
		
		/*
		 * 숫자 출력 포맷
		 * %d: decimal, 정수 출력
		 * %f: float, 실수 출력
		 */
		
		System.out.printf("%d + %d = %d\n", 23, 18, 23+18);
		System.out.printf("숫자 연산: 23 + 18 = %d\n", 23+18);
		
		System.out.printf("사칙연산(53,17) %d %d %d %d \n", 53+17, 53-17, 53*17, 53/17);
		System.out.printf("더하기: 53 + 17 = %d\n", 53+17);
		System.out.printf("빼기: 53 - 17 = %d\n", 53-17);
		System.out.printf("곱하기: 53 * 17 = %d\n", 53*17);
		System.out.printf("나누기: 53 / 17 = %d\n", 53/17);
	}
}

