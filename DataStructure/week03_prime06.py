def is_prime(n) -> bool:
    """
    소수 판정 함수
    :param n: 양의 정수
    :return: 소수면 True, 아니면 False
    """
    if k < 2 :
        return False
    else:
        i = 2
        while i*i <= k:
            if k % i == 0:
                return False
            i = i + 1
    return True
       

# start = int(input("input positive number: "))
# end = int(input("input positive number: "))
start, end = list(map(int, input("input positive start & end number: ").split()))
print(start, end)

for k in range(start, end+1):
    if is_prime(k):
        print(k, end=' ')