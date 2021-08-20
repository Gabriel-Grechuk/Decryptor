# DECRYPTOR
A simple AES 256 encrypted file decryptor.
You just need to know the key. This is not a brute force software.

## USAGE
    Decryptor.exe -k "[KEY]" -e "[FILE EXTENTION]" -p "[PATH TO FOLDER OR FILE]"

    ex:
    Decryptor.exe -k "ZXCVBNMASD!@#$12345" -e ".crypted" -p "C:\User\MyUser\Desktop"
    Decryptor.exe -k "12346863413418765AS" -e ".aes" -p "C:\User\MyUser\Desktop\word-doc.docx"

    KEY:                    Key used to encrypt your files.
    FILE EXTENTION:         Extension used to mark the encrypted files i. e. '*.kraken', '*.crypt' '*.abc' etc.
    PATH TO FOLDER OR FILE: Folder with the files to decrypt or the file it self.

### !!!BE CAREFUL, IT IS A VERY PRIMITIVE  SOFTWARE AND MAY CORRUPT YOUR FILES IF USED INAPPROPRIATELY!!!
Pass the command line arguments as it is shown above. the parser are very limited and primitive and may break or corrupt the files if any argument where passed wrong.

## CONTRIBUTE
Any new functionality or bug correction will be welcome. please, open a pull request and I will analyze and merge it.
