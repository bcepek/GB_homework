from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes
from telegram.ext import filters, MessageHandler
import bot_commands as bc
import operation_logic as ol

app = ApplicationBuilder().token(
    "token").build()

app.add_handler(CommandHandler("help", bc.help))
app.add_handler(CommandHandler("info", bc.info))
app.add_handler(MessageHandler(filters.TEXT, ol.parse))
print('Start!')
app.run_polling()
