number = int(input("input positive number:"))

if number < 2 :
    print(f"{number} is NOT prime number")
else:
    is_prime = True
    # for i in range(1, number+1):
    for i in range(2, number):
        if number % i == 0:
            is_prime = False
            break
        print(i, end=' ')
    # 숫자가 큰 경우에, 반복문이 비효율적이니 효율적으로 빠르게 돌 수 있게끔 바꾸기.(힌트:배수)
    # if is_prime == 2:
    if is_prime:
        print(f"{number} is prime number")
    else:
        print(f"{number} is NOT prime number")