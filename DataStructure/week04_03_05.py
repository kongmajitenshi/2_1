def print_poly(p_x):
	term = len(p_x) - 1# 최고차항 숫자 = 배열길이-1
	poly_str = "P(x) = "
	
	for i in range(len(px)):
		coef = p_x[i]# 계수

		if coef == 0:
			term = term - 1
			continue

		if coef >= 0 and i > 0:
			poly_str += "+"
		# poly_str += str(coef) + "x^" + str(term) + " "
		poly_str += f"{coef}x^{term} "
		term -= 1

	return poly_str


def calculation_poly(x_val, p_x) :
	ret_value = 0
	term = len(p_x) - 1	# 최고차항 숫자 = 배열길이-1

	for i in range(len(px)) :
		coef = p_x[i]	# 계수
		ret_value += coef * x_val ** term
		term -= 1

	return ret_value


px = [7, -4, 0, 5]			# = 7x^3 -4x^2 +0x^1 +5x^0


if __name__ == "__main__" :

	p_str = print_poly(px)
	print(p_str)

	x_value = int(input("X 값-->"))

	px_value = calculation_poly(x_value, px)
	print(px_value)

	
