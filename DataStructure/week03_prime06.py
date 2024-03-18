def is_prime(n) -> bool:
    """
    :param n: 양의 정수
    :return: 소수면 True, 아니면 False
    """
    is_prime = True
    if k < 2 :
        is_prime = False
    else:
        i = 2
        while i*i <= k:
            if k % i == 0:
                is_prime = False
                break
            i = i + 1
       


start = int(input("input positive number:"))
end = int(input("input positive number:"))

for k in range(start, end+1):
    if is_prime(k):
        print(k, end=' ')