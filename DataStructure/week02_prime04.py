number = int(input("input positive number:"))

is_prime = True
if number < 2 :
    # print(f"{number} is NOT prime number")
    is_prime = False
else:
    i = 2
    while i*i <= number:
        if number % i == 0:
            is_prime = False
            break
        # print(i, end=' ')
        i = i + 1

    # 숫자가 큰 경우에, 반복문이 비효율적이니 효율적으로 빠르게 돌 수 있게끔 바꾸기.(힌트:배수)
        
if is_prime:
    print(f"{number} is prime number")
else:
    print(f"{number} is NOT prime number")