def factorial(number) -> int:
    """
    매개변수 number로 받은 값의 팩토리얼 값을 반환하는 함수
    parameter number: Value delivered as an argument
    return: Factorial result value
    """
    result = 1
    for i in range(2, number+1):
        result = result * i
    return result

def nCr(n, r) -> int:
    """
    n과 r로 받은 매개변수들의 값을 사용하여 combination의 결과를 반환
    param n: 전체 갯수
    param r: 사용할 갯수
    return: nCr
    """
    return int(factorial(n) / (factorial(n-r)*factorial(r)))


# help(abs) abs = 절댓값, help는 도움말 출력.

# help(factorial)
# print(factorial(4))
# print(factorial(5))
# print(nCr(10, 5))
n = int(input("input a set of elements: "))
r = int(input("input r elements: "))
print(f"{n}C{r} = {nCr(n,r)}")