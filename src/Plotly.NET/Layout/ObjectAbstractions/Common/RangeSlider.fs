﻿namespace Plotly.NET.LayoutObjects

open Plotly.NET
open DynamicObj
open System
open System.Runtime.InteropServices

//rangeslider
//Parent: layout.xaxis
//Type: object containing one or more of the keys listed below.
type RangeSlider() =
    inherit DynamicObj()

    static member init
        (
            [<Optional; DefaultParameterValue(null)>] ?BgColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?BorderColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?BorderWidth: float,
            [<Optional; DefaultParameterValue(null)>] ?AutoRange: bool,
            [<Optional; DefaultParameterValue(null)>] ?Range: StyleParam.Range,
            [<Optional; DefaultParameterValue(null)>] ?Thickness: float,
            [<Optional; DefaultParameterValue(null)>] ?Visible: bool,
            [<Optional; DefaultParameterValue(null)>] ?YAxisRangeMode: StyleParam.RangesliderRangeMode,
            [<Optional; DefaultParameterValue(null)>] ?YAxisRange: StyleParam.Range
        ) =
        RangeSlider()
        |> RangeSlider.style (
            ?BgColor = BgColor,
            ?BorderColor = BorderColor,
            ?BorderWidth = BorderWidth,
            ?AutoRange = AutoRange,
            ?Range = Range,
            ?Thickness = Thickness,
            ?Visible = Visible,
            ?YAxisRangeMode = YAxisRangeMode,
            ?YAxisRange = YAxisRange
        )


    static member style
        (
            [<Optional; DefaultParameterValue(null)>] ?BgColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?BorderColor: Color,
            [<Optional; DefaultParameterValue(null)>] ?BorderWidth: float,
            [<Optional; DefaultParameterValue(null)>] ?AutoRange: bool,
            [<Optional; DefaultParameterValue(null)>] ?Range: StyleParam.Range,
            [<Optional; DefaultParameterValue(null)>] ?Thickness: float,
            [<Optional; DefaultParameterValue(null)>] ?Visible: bool,
            [<Optional; DefaultParameterValue(null)>] ?YAxisRangeMode: StyleParam.RangesliderRangeMode,
            [<Optional; DefaultParameterValue(null)>] ?YAxisRange: StyleParam.Range
        ) =
        fun (rangeslider: RangeSlider) ->
            BgColor |> DynObj.setValueOpt rangeslider "bgcolor"
            BorderColor |> DynObj.setValueOpt rangeslider "bordercolor"
            BorderWidth |> DynObj.setValueOpt rangeslider "borderwidth"
            AutoRange |> DynObj.setValueOpt rangeslider "autorange"
            Range |> DynObj.setValueOptBy rangeslider "range" StyleParam.Range.convert
            Thickness |> DynObj.setValueOpt rangeslider "thickness"
            Visible |> DynObj.setValueOpt rangeslider "visible"

            let yAxis =
                let tmp = DynamicObj()
                YAxisRangeMode |> DynObj.setValueOptBy tmp "rangemode" StyleParam.RangesliderRangeMode.convert
                YAxisRange |> DynObj.setValueOptBy tmp "range" StyleParam.Range.convert
                tmp

            yAxis |> DynObj.setValue rangeslider "yaxis"


            rangeslider
