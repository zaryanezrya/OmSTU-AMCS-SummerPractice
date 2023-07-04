﻿﻿namespace SpaceBattle;
public class SpaceShip
{
    
    public double[] position = new double[2]{double.NaN, double.NaN};
    public double[] speed = new double[2]{double.NaN, double.NaN};
    public double fuel;
    public double eps=-1e-9;
    public double fuelF=double.NaN;
    public double angle = 0;
    public double speedAngle = 0;
    public bool changeAngle = true;
    public bool possibility_of_movement = true;



    public SpaceShip()
    {}

    public void SetPosition(double[] pos)
    {
        this.position = pos;
    }
    public void SetSpeed(double[] speed){
        this.speed = speed;
    }
    public void SetSPosOfMove(bool possibility_of_movement){
        this.possibility_of_movement = possibility_of_movement;
    }
    
    public void SetFuel(double fuel){
        this.fuel = fuel;
    }
    public void SetFuelF(double fuelF){
        this.fuelF = fuelF;
    }

    public void SetAnglSpeed(double speedAngle){
        this.speedAngle = speedAngle;
    }
    public void SetAngle(double angle){
        this.angle = angle;
    }
    public void SetChangeAngle(bool changeAngle){
        this.changeAngle = changeAngle;
    }

    public double[] Movement (){
        if(double.IsNaN(position[0]) || double.IsNaN(position[1])){
            throw new Exception();
        }
        else if (double.IsNaN(speed[0]) || double.IsNaN(speed[1])){
            throw new Exception();
        }
        else if (possibility_of_movement==false){
            throw new Exception();
        }
        else{
            position[0] += speed[0];
            position[1] += speed[1];
            return position;
        }
    }
    public double MovementFuel(){
        if ((fuel-fuelF)<=eps) throw new Exception();
        else{
            fuel-=fuelF;
            return fuel;
        }
    }
    public double Rotation(){
        if (double.IsNaN(angle)){
            throw new Exception();
        }
        else if(double.IsNaN(speedAngle)){
            throw new Exception();
        }
        else if(changeAngle == false){
            throw new Exception();
        }
        else{
            angle += speedAngle;
            return angle;
        }
    }
 }