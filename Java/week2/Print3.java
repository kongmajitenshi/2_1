package week2;

public class Print3 {
	public static void main(String[] args) {
		System.out.println(17+35);
		
		System.out.println("17+35");
		// 쌍따옴표 내부 내용은 모두 문자열
		
		System.out.println("17 + 35 = " + 17 + 35);
		// 문자열 뒤에 +로 이어붙이면 뒤에 오는 데이터도 문자열로 인식함
		
		System.out.println("17 + 35 = " + (17 + 35));
		// 연산식으로 사용하고자 하면 괄호로 묶어준다.
		
		/*
		 * 문자열의 출력 포맷(printf)
		 * %기호
		 * 	s: 문자열
		 */
		 
		System.out.printf("이름: %s, %s, %s \n", "자바", "이클립스");
		// 매개변수 느낌으로 앞에 format 개수 만큼 인자 넘겨 줘야함.
		
	}
}
