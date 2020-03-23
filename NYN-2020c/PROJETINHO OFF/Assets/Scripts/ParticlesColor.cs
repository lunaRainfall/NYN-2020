using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesColor : MonoBehaviour
{
    public ParticleSystem walkParticle;
    public ParticleSystem jumpParticle;
    public ParticleSystem fallParticle;
    public ParticleSystem rainbowParticle;

    public PlatformController platControl;

    public Gradient defaultGradient;
    public Gradient redGradient;
    public Gradient greenGradient;
    public Gradient blueGradient;
    public Gradient cyanGradient;
    public Gradient magentaGradient;
    public Gradient yellowGradient;
    public Gradient whiteGradient;
    public Gradient rainbowGradient;

    [Header("BACKGROUND PARTICLES")]
    public GameObject redParticles;

    void Start()
    {
        rainbowParticle.gameObject.SetActive(false);
    }

    void Update()
    {
        if (platControl.whiteState == false)
        {
            rainbowParticle.gameObject.SetActive(false);
        }
    }


    public void UpdateParticleColor()
    {
        var colWalk = walkParticle.colorOverLifetime;
        var colJump = jumpParticle.colorOverLifetime;
        var colFall = fallParticle.colorOverLifetime;

        if (platControl.greenState == true && !(platControl.blueState || platControl.redState))
        {

            colWalk.color = greenGradient;
            colJump.color = greenGradient;
            colFall.color = greenGradient;

        }
        else if (platControl.redState == true && !(platControl.blueState || platControl.greenState))
        {

            colWalk.color = redGradient;
            colJump.color = redGradient;
            colFall.color = redGradient;
        }
        else if (platControl.blueState == true && !(platControl.redState || platControl.greenState))
        {

            colWalk.color = blueGradient;
            colJump.color = blueGradient;
            colFall.color = blueGradient;
        }
        else if (platControl.cyanState == true && !(platControl.magentaState || platControl.yellowState))
        {

            colWalk.color = cyanGradient;
            colJump.color = cyanGradient;
            colFall.color = cyanGradient;
        }
        else if (platControl.magentaState == true && !(platControl.cyanState || platControl.yellowState))
        {

            colWalk.color = magentaGradient;
            colJump.color = magentaGradient;
            colFall.color = magentaGradient;
        }
        else if (platControl.yellowState == true && !(platControl.cyanState || platControl.magentaState))
        {

            colWalk.color = yellowGradient;
            colJump.color = yellowGradient;
            colFall.color = yellowGradient;
        }
        else if (platControl.yellowState && platControl.cyanState && platControl.magentaState)
        {

            colWalk.color = rainbowGradient;
            colJump.color = rainbowGradient;
            colFall.color = rainbowGradient;
            rainbowParticle.gameObject.SetActive(true);
        }
        else
        {

            colWalk.color = defaultGradient;
            colJump.color = defaultGradient;
            colFall.color = defaultGradient;
        }

    }
}

