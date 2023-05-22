using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] Transform visual;
    [SerializeField] CoinData coinData;
    [SerializeField] BaseAnimation baseAnimation;
    [SerializeField] PlayManager playManager;

    public int Value { get => coinData.value; }

    private void Start()
    {
        visual.GetComponent<Renderer>().material = coinData.material;
        if (baseAnimation != null )
        {
            baseAnimation.Animate(visual);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            Destroy(this.gameObject);
            playManager.CoinValue += coinData.value;
        }
    }
}
