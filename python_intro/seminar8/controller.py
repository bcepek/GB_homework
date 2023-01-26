import view
import model

def start():
    model.get_last_student_id()
    model.get_classes()
    
    stop = False
    while not stop:
        model.save_student(model.add_new_student())
        model.print_classes()
        if view.get_student_info(' "q" to stop').lower() == 'q':
            stop = True
    model.save_classes()
    model.save_last_student_id()
    
    