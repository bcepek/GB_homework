import operation_logic as ol
import data_io as io
from telegram.ext import ContextTypes
from telegram import Update

async def manage_book(update: Update, context: ContextTypes.DEFAULT_TYPE):
    data_csv = io.read_csv('data_to_add_csv.csv')
    data_txt_f1 = io.read_txt_f1('data_to_add_f1.txt')
    data_txt_f2 = io.read_txt_f2('data_to_add_f2.txt')
    
    data = ol.data_join(ol.data_join(data_txt_f1, data_txt_f2), data_csv)
    data = ol.remove_recod(data, 2)
    
    io.write_txt_f1("recorded_data_f1.txt", data)
    io.write_txt_f2("recorded_data_f2.txt", data)
    io.write_csv("recorded_data.csv", data)
    