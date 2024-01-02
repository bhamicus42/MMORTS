using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
GalCoord, short for Galactic Coordinates, is a struct  of three members that contains spherical coordinates describing a point location in the galaxy.
TODO: reimplement using mathematical convention as per https://mathworld.wolfram.com/SphericalCoordinates.html
Implements code by Morten Nobel: https://github.com/mortennobel/CameraLib4U/blob/master/Assets/_CameraLib4U/Scripts/SphericalCoordinates.cs
*/
struct GalCoord {
    public polar;   // polar coordinate describing angle of radial line from a Cartesian z-axis , commonly denoted as theta
    public radial;  // radial coordinate describing length of a radial line, commonly denoted as r
    public azimuth; // azimuthal coordinate describing the angle of a radial line in the Cartesian x-y plane, commonly denoted as phi
    public static Vector3 galacticToCartesian(float polar, float radial, float azimuth) {
        Vector3 cartesian;
        float a = radial * Mathf.Cos(polar);
        cartesian.x = a * Mathf.Cos(azimuth);
        //cartesian.y = a * Mathf.Cos(azimuth);
        //cartesian.z = a * Mathf.Cos(azimuth);
        return cartesian;
    }
}

public class Galaxy {
    // each system is procedurally generated, so rather than storing all systems in memory, only their galactic coordinates are stored and the rest can be recalled
    private GalCoord systems;
    public Galaxy(){

    }
}
