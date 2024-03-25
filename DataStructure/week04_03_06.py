def print_poly(p_x, t_x):
    poly_str = "P(x) = "

    for i in range(len(px)):
        coef = p_x[i]  # 계수
        term = t_x[i]

        if coef >= 0 and i > 0:
            poly_str += "+"
        poly_str += f"{coef}x^{term} "

    return poly_str


def calculation_poly(x_val, p_x, t_x):
    ret_value = 0

    for i in range(len(px)):
        coef = p_x[i]  # 계수
        term = t_x[i]
        ret_value += coef * x_val ** term

    return ret_value


tx = [300, 20, 0]
px = [7, -4, 5]
# = 7x^300 -4x^20 +5

if __name__ == "__main__":
    print(id(tx[0]), id(tx[1]), id(tx[2]))
    p_str = print_poly(px, tx)
    print(p_str)

    x_value = int(input("X 값: "))

    px_value = calculation_poly(x_value, px, tx)
    print(px_value)
