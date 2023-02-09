# CW5-Adapter_Practice

### Interesting Notes:
- There is an accesibility error with BearAdapter's constructor if:
1. BearAdapter is not specified as public
2. IBear is not specified as public
- Don't know why it occurs but it is a simple fix to set them both to public rather than internal.
