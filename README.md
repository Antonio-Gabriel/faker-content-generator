# Faker Content Generator

A simple service to generate faker sale data to be processed in another project as test case.

## How to run

First, create a folder `temp` and put in a file `sales.csv` and add these data from headers

```csv
Id,Date,Product,Quantity,UnitPrice

```
Don't forget to left an empty space below.

After all of that, just run the command below:

```bash
dotnet run
```

Your file will be load with faker sales products
