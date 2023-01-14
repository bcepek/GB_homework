# Напишите программу, удаляющую из текста все слова, содержащие ""абв"".

input_filename = 'task1_input.txt'
output_filename = 'task1_output.txt'

input_file = open(input_filename, 'r')
text = input_file.readline()
input_file.close()

print(text)
print(text.replace('abc', ''))

text = text.replace('abc', '')

output_file = open(output_filename, 'w')
output_file.write(text)
output_file.close()
