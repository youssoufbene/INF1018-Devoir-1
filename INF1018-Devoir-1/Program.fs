open Devoir1

[<EntryPoint>]
let main argv =
    printfn "Vitesse 0  : %f/h -> %d/min" (calculateHourlyProductionRate 0) (calculateWorkingCarsPerMinute 0)
    printfn "Vitesse 1  : %f/h -> %d/min" (calculateHourlyProductionRate 1) (calculateWorkingCarsPerMinute 1)
    printfn "Vitesse 5  : %f/h -> %d/min" (calculateHourlyProductionRate 5) (calculateWorkingCarsPerMinute 5)
    printfn "Vitesse 10 : %f/h -> %d/min" (calculateHourlyProductionRate 10) (calculateWorkingCarsPerMinute 10)
    0