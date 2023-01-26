import view

student_id_counter = 0
students = {}
classes = {}

def add_new_student():
    new_student = dict()
    new_student['id'] = get_new_id()
    new_student['First Name'] = view.get_student_info("1st name > ")
    new_student['Last Name'] = view.get_student_info("Last name > ")
    new_student['Birth date'] = view.get_student_info("Birth date > ")
    add_student_in_class(new_student['id'])
    return new_student

def get_new_id():
    global student_id_counter
    student_id_counter += 1
    return student_id_counter

def save_student(student):
    with open('students.csv', 'a') as file:
        file.write(f"{student['id']};{student['First Name']};{student['Last Name']};{student['Birth date']}\n")
        
def add_student_in_class(student_id):
    global classes
    student_class = view.get_student_info('class number > ')
    if student_class in classes:
        classes[student_class].append(student_id)
    else:
        classes[student_class] = [str(student_id)]

def get_last_student_id():
    global student_id_counter
    with open('last_student_id.txt', 'r') as file:
        student_id_counter = int(file.read())
        
def save_last_student_id():
    global student_id_counter
    with open('last_student_id.txt', 'w') as file:
        file.write(str(student_id_counter))
        
def save_classes():
    with open('classes.txt', 'w') as file:
        for key, value in classes.items():
            string_to_write = key+': '+str(value)+'\n'
            file.write(string_to_write.replace("'",""))

def get_classes():
    with open('classes.txt', 'r') as file:
        classes_data = file.readlines()
        global classes
        for element in classes_data:
            classes[element[:element.index(':')]] = element[element.index('[')+1:-2].split(', ')
        print(f"current classes and students in them are:\n{classes}")

def print_classes():
    print(classes)