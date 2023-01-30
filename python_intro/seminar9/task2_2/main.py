import user_interface as ui
from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes
from telegram import Update


app = ApplicationBuilder().token("insert token here").build()
print('Server started')

async def help(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("/help\n/manage_book\n")
        
app.add_handler(CommandHandler("help", help))
app.add_handler(CommandHandler("manage_book", ui.manage_book))


app.run_polling()

