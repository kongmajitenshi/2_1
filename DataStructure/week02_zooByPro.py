animals = [
    {"name":"코끼리", "weight":6, "preference":6},
    {"name":"하마", "weight":4, "preference":3},
    {"name":"기린", "weight":5, "preference":5},
    {"name":"물소", "weight":3, "preference":4},
    {"name":"호랑이", "weight":2, "preference":1},
    {"name":"사자", "weight":2, "preference":1},
    {"name":"얼룩말", "weight":2, "preference":1}
]

# print(animals)
animals.sort(key=lambda animal: animal["preference"],)
# animals.sort(key=lambda animal: animal["preference"], reverse=True)
# print(animals)

loaded_animals = list() # loaded = 적재된 (총알 장전 된 상태를 loaded 라고 함), 동물들의 이름 담을거
current_weight = 0 # 현재 트럭에 실은 동물들 무게
total_preference = 0 # 선호도 총 합

for animal in animals:
    if current_weight + animal["weight"] <= 7:
        loaded_animals.append(animal["name"])
        current_weight = current_weight + animal["weight"]
        total_preference = total_preference + animal["preference"]
    else:
        pass
    pass

print(f"트럭에 탑승한 동물들: {loaded_animals}")
print(f"총 중량: {current_weight}")
print(f"총 선호도: {total_preference}")