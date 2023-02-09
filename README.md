# CW5-Adapter_Practice

### For grading:
- Implementation is in CW5-AdapterPrac/
- UML is in CW5-JKW.dia (base folder)

### Interesting Notes:
- There is an accesibility error with BearAdapter's constructor if:
1. BearAdapter constructor is not specified as public
2. IBear is not specified as public
- Don't know why it occurs but it is a simple fix to set them both to public rather than internal.
