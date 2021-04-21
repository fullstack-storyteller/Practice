def make_a_sentence(words):
    first_letter_caps=words.capitalize()
    if words.startswith(('what', 'when', 'where', 'whose', 'whom', 'how')):#startswith takes three argument at max, first one being a tuple
        return '{}?'.format(first_letter_caps)
    else:
        return '%s.'%first_letter_caps

# print(make_a_sentence('how are you'))
# print(make_a_sentence('this is promising'))
paragraph =[]

while True:
    user_input =input('Say something: ')
    if(user_input=="/end"):# don't you back slash
        #when entering a loop first things first we need to find out and write the logic for getting out of it.
        break
    else:
        paragraph.append(make_a_sentence(user_input))

print(" ".join(paragraph)) #join generally takes a iterable collection like list and joins the items in it with character it is called upon

########good attempt
# user_text=''
# test_for_end=''
# while test_for_end=="\end":
#     test_for_end = input('Say something: ')
    
#     if test_for_end.startswith(('how', 'why', 'what', 'where','whose', 'whom')):
#         test_for_end+='?'
#     else:
#         test_for_end+='.'
#     user_text+=test_for_end.capitalize()+' '

# print(user_text)