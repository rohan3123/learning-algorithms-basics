bruh=[12,35,96,9,60]

def find_the_biggest_number(bruh):
    max_numb = 0
    
    for num in bruh:
        #if the number in the array is bigger then max_numb it sets the max_numb to the current itterated number
        if num > max_numb:
            max_numb = num
            
    
    return max_numb

print("the maximum number in the array is:", find_the_biggest_number(bruh))