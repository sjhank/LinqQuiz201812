<link rel="stylesheet" href="md-styles.css">

### 答案

#### Quiz01

``` Csharp
var query = data
    .Select(p => p * 2);

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

``` Csharp
var query = from p in data
            select p * 2;

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

---
#### Quiz02

``` Csharp
var query = data
    .Where(p => p % 2 == 0)
    .Select(p => p * 2);

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

``` Csharp
var query = from p in data
            where p % 2 == 0
            select p * 2;

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

---
#### Quiz03

``` Csharp
var query = data
    .Where(p => p % 2 == 0)
    .OrderByDescending(p => p)
    .Select(p => p * 2);

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

``` Csharp
var query = from p in data
            where p % 2 == 0
            orderby p descending
            select p * 2;

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

---
#### Quiz04

``` Csharp
var query = employeeData.AsEnumerable()
    .Select(p => Convert.ToString(p["LastName"]));

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

``` Csharp
var query = from p in employeeData.AsEnumerable()
            select Convert.ToString(p["LastName"]);

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

---
#### Quiz05

``` Csharp
var query = employeeData.AsEnumerable()
    .Where(p => Convert.ToString(p["Title"]) == "PG")
    .OrderByDescending(p => Convert.ToDateTime(p["HireDate"]))
    .Select(p => Convert.ToInt32(p["ID"]));

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

``` Csharp
var query = from p in employeeData.AsEnumerable()
            where Convert.ToString(p["Title"]).Equals("PG")
            orderby Convert.ToDateTime(p["HireDate"]) descending
            select Convert.ToInt32(p["ID"]);

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

---
#### Quiz06

``` Csharp
var query = employeeData.AsEnumerable()
    .Where(p => Convert.ToString(p["Department"]) == "B2")
    .Max(p => Convert.ToDateTime(p["HireDate"]));

Console.WriteLine(query);
```

``` Csharp
var query = (from p in employeeData.AsEnumerable()
             where Convert.ToString(p["Department"]).Equals("B2")
             select Convert.ToDateTime(p["HireDate"])).Max();

Console.WriteLine(query);
```

---
#### Quiz07

``` Csharp
var query = employeeData.AsEnumerable()
    .FirstOrDefault(p => Convert.ToString(p["Department"]) == "C1");

Console.WriteLine(query["ID"]);
```

``` Csharp
var query = (from p in employeeData.AsEnumerable()
             where Convert.ToString(p["Department"]).Equals("C1")
             select p).FirstOrDefault();

Console.WriteLine(query["FirstName"]);
```

---
#### Quiz08

``` Csharp
var query = employeeData.AsEnumerable()
    .Skip(5).Take(5);

foreach (var item in query)
{
    Console.WriteLine(item["ID"]);
}
```

``` Csharp
int employeesInPage = 5; // 每頁筆數
int pageIndex = 3; // 目前頁次

var query = employeeData.AsEnumerable()
    .Skip((pageIndex - 1) * employeesInPage).Take(employeesInPage);

foreach (var item in query)
{
    Console.WriteLine(item["ID"]);
}
```

---
#### Quiz09

``` Csharp
var query = employeeData.AsEnumerable()
    .Any(p => Convert.ToDateTime(p["HireDate"]).Year == 2016 && Convert.ToDateTime(p["HireDate"]).Month == 6);

Console.WriteLine(query);
```

``` Csharp
var query = (from p in employeeData.AsEnumerable()
             where Convert.ToDateTime(p["HireDate"]).Year == 2016 && Convert.ToDateTime(p["HireDate"]).Month == 6
             select p).Any();

Console.WriteLine(query);
```

``` Csharp
// 進階
var query = employeeData.AsEnumerable()
    .Any(p =>
    {
        DateTime hireDate = Convert.ToDateTime(p["HireDate"]);
        return hireDate.Year == 2016 && hireDate.Month == 6;
    });

Console.WriteLine(query);
```

---
#### Quiz10

``` Csharp
var query = employeeData.AsEnumerable()
    .Select(p => Convert.ToString(p["LastName"]))
    .Distinct();

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

``` Csharp
var query = (from p in employeeData.AsEnumerable()
             select Convert.ToString(p["LastName"])).Distinct();

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

---
#### Quiz11

``` Csharp
var query = employeeData.AsEnumerable()
    .ToDictionary(
        p => Convert.ToInt32(p["ID"]),
        q => Convert.ToString(q["FirstName"]));

foreach (var item in query)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}
```

---
#### Quiz12

``` Csharp
var query = employeeData.AsEnumerable()
    .GroupBy(p => Convert.ToString(p["Department"]))
    .Select(p => new
    {
        p.Key,
        Data = p.ToList()
    });
```

``` Csharp
var query = from p in employeeData.AsEnumerable()
            group p by Convert.ToString(p["Department"]) into grp
            select new
            {
                grp.Key,
                Data = grp.ToList()
            };
```

---
#### Quiz13

``` Csharp
var query = data
    .SelectMany(p => p.People);

foreach (var item in query)
{
    Console.WriteLine(item);
}
```

``` Csharp
// 進階題
DataTable employeeData = Employees.GetEmployeesDataTable();
var query = employeeData.AsEnumerable()
    .GroupBy(p => Convert.ToString(p["Department"]))
    .Select(p => new
    {
        p.Key,
        Data = p.ToList()
    });

var query1 = query.SelectMany(p => p.Data);

foreach (var item in query1)
{
    Console.WriteLine(item["FirstName"]);
}
```

---
#### Quiz14

``` Csharp
var query = departmentData.AsEnumerable()
    .Join(employeeData.AsEnumerable(),
        dep => Convert.ToString(dep["ID"]),
        emp => Convert.ToString(emp["Department"]),
        (dep, emp) => new
        {
            Department = dep,
            Employee = emp
        });
```

``` Csharp
var query = from dep in departmentData.AsEnumerable()
            join emp in employeeData.AsEnumerable() on Convert.ToString(dep["ID"]) equals Convert.ToString(emp["Department"])
            select new
            {
                Department = dep,
                Employee = emp
            };
```

---
#### Quiz15

``` Csharp
var query = departmentData.AsEnumerable()
    .GroupJoin(employeeData.AsEnumerable(),
        dep => Convert.ToString(dep["ID"]),
        emp => Convert.ToString(emp["Department"]),
        (dep, emps) => new
        {
            Department = dep,
            Employees = emps
        })
    .SelectMany(
        p => p.Employees.DefaultIfEmpty(),
        (p, emp) => new
        {
            p.Department,
            Employee = emp
        });
```

``` Csharp
var query = from dep in departmentData.AsEnumerable()
            join emp in employeeData.AsEnumerable() on Convert.ToString(dep["ID"]) equals Convert.ToString(emp["Department"]) into emps
            from emp2 in emps.DefaultIfEmpty()
            select new
            {
                Department = dep,
                Employee = emp2
            };
```

恭喜完成! 🎉🎉🎉

<script src="md-styles.js"></script>
