using System.Collections;
using UnityEngine;
public class Fire : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private bool isAutomatic;
    //[SerializeField] private Stats stats;
    private GameObject laserBeamPrefab;
    private int speedProjectTile;
    private float rateOfFire;
    public bool IsAutomatic { set { isAutomatic = value; } }
    public GameObject LaserBeamPrefab { set { laserBeamPrefab = value; } }
    public int SpeedProjectTile { set { speedProjectTile = value; } }
    public float RateOfFire { set { rateOfFire = value; } }
    private void Start()
    {
        StartCoroutine(AutoFire());
    }
    private IEnumerator AutoFire()
    {
        if (!isAutomatic) yield break;
        FireLaserBeam();
        yield return new WaitForSeconds(1 / rateOfFire);
        StartCoroutine(AutoFire());
    }
    public void FireLaserBeam()
    {
        // spawn laser beam with direction = direction of transform
        GameObject newLaserBeam = Instantiate(laserBeamPrefab, firePoint.position, transform.rotation);
        // add force
        newLaserBeam.GetComponent<Rigidbody2D>().AddForce(newLaserBeam.transform.up * speedProjectTile);
    }
}