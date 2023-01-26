with open('classes.txt', 'r') as file:
    classes = {}
    classes_data = file.readlines()
    for element in classes_data:
        class_num = element[:element.index(':')]
        class_content = element[element.index('[')+1:-2].split(', ')
        classes[class_num] = class_content
    print(f"current classes and students in them are:\n{classes}")