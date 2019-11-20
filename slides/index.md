- title : How slow your code is?
- description : . Denver Dev Day (November 22, 2019)
- author : Grigoriy Belenkiy
- theme : simple
- transition : convex

***
- data-background : ./images/sponsors-slide.png
- data-background-transition : none

' Sponsors slide (required by organizators)

***

### How slow your code is?

![Race](./images/tortoise-hare-race.jpg)

<small>Grigoriy Belenkiy<br/>
Software engineer at ![361 Capital](./images/361-logo-gray.png#align-hack)
<br/>
<a href="https://twitter.com/@grishace/">@grishace</a>
<br/>
<br/>
Denver Dev Day<br/>
November 22, 2019</small>

***

### TIMTOWTDI

![Perl motto](./images/perl-camel.png)

---

![Knuth quote](./images/premature-optimization.jpg)


***

### <span class="fragment">Micro-</span>Benchmarking

<ul>
<span class="fragment"><li>DateTime.Now&nbsp;<span class="fragment" style="color:gray;">&mdash;&nbsp;na&iuml;ve</span></li></span>
<span class="fragment"><li>System.Diagnostics.Stopwatch&nbsp;<span class="fragment" style="color:gray;">&mdash;&nbsp;better</span></li></span>
<span class="fragment"><li>BenchmarkDotNet</li></span>
</ul>

***

### BenchmarkDotNet

![BenchmarkDotNet logo](./images/benchmarkdotnet-logo.png)

---

### BenchmarkDotNet

* .NET Framework (4.6+), .NET Core (2.0+), Mono, CoreRT
* C#, F#, Visual Basic
* Windows, Linux, macOS

---

### BenchmarkDotNet

* Standard benchmarking routine
* Execution control
* Statistics
* Relative performance
* Memory diagnostics
* Parametrization
* Powerful reporting system

' Standard benchmarking routine:
' generating an isolated project per each benchmark method; 
' auto-selection of iteration amount; warmup; overhead evaluation; and so on
' Execution control: 
' BenchmarkDotNet tries to choose the best possible way to evaluate performance, but you can also 
' manually control amount of iterations, switch between cold start and warmed state, set the accuracy level,
' tune GC parameters, change environment variables, and more
' Statistics:
' by default, you will see the most important statistics like mean and standard deviation; 
' but you can also manually ask for min/max values, confidence intervals, skewness, kurtosis, quartile, 
' percentiles, or define own metrics
' Comparing environments:
' Easy way to compare different environments (x86 vs x64, LegacyJit vs RyuJit, Mono vs .NET Core, and so on)
' Relative performance:
' you can easily evaluate difference between different methods of environments
' Memory diagnostics: 
' the library not only measure performance of your code, but also prints information about memory traffic 
' and amount of GC collections
' Disassembly diagnostics:
' you can ask for an assembly listing with the help of single additional attribute
' Parametrization:
' performance can be evaluated for different sets of input parameters like in popular unit test frameworks
' Environment information:
' when your share performance results, it's very important to share information about your environment; 
' BenchmarkDotNet automatically prints the exact version of your OS and processor; amount of physical CPU, 
' physical cores, and logic cores; hypervisor (if you use it); frequency of the hardware timer; the JIT-compiler 
' version; and more
' Command-line support:
' you can manage thousands of benchmark, group them by categories, filter and run them from command line
' Powerful reporting system: it's possible to export benchmark results to markdown, csv, html, plain text, png plots

***

### Demo

***

### Questions?

[![https://github.com/grishace/ddd-bench](./images/qrcode.png)](https://github.com/grishace/ddd-bench)<br/>
[https://github.com/grishace/ddd-bench](https://github.com/grishace/ddd-bench)

[https://benchmarkdotnet.org/](https://benchmarkdotnet.org/)
