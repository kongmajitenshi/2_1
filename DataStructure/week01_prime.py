number = int(input("input positive number:"))

if number < 2 :
    print(f"{number} is NOT prime number")
else:
    count = 0
    # for i in range(1, number+1):
    for i in range(2, number):
        if number % i == 0:
            count = count + 1
            break
        # print(i, end=' ')
    
    # if count == 2:
    if count == 0:
        print(f"{number} is prime number")
    else:
        print(f"{number} is NOT prime number")