using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    #region Transform

    public static void SetPosX(this Transform transform, float pos)
    {
        Vector3 position = transform.position;
        position.x = pos;
        transform.position = position;
    }

    public static void SetPosY(this Transform transform, float pos)
    {
        Vector3 position = transform.position;
        position.y = pos;
        transform.position = position;
    }

    public static void SetPosZ(this Transform transform, float pos)
    {
        Vector3 position = transform.position;
        position.z = pos;
        transform.position = position;
    }

    public static void SetRotaX(this Transform transform, float rot)
    {
        Quaternion rotation = transform.rotation;
        rotation.x = rot;
        transform.rotation = rotation
    }

    public static void SetRotaY(this Transform transform, float rot)
    {
        Quaternion rotation = transform.rotation;
        rotation.y = rot;
        transform.rotation = rotation;
    }

    public static void SetRotaZ(this Transform transform, float rot)
    {
        Quaternion rotation = transform.rotation;
        rotation.z = rot;
        transform.rotation = rotation;
    }
    public static void AddPosX(this Transform transform, float pos)
    {
        Vector3 position = transform.position;
        position.x = pos;
        transform.position += position;
    }

    public static void AddPosY(this Transform transform, float pos)
    {
        Vector3 position = transform.position;
        position.y = pos;
        transform.position = +position;
    }

    public static void AddPosZ(this Transform transform, float pos)
    {
        Vector3 position = transform.position;
        position.z = pos;
        transform.position = +position;
    }

    public static void AddRotaX(this Transform transform, float rot)
    {
        Quaternion rotation = transform.rotation;
        rotation.x = rot;
        transform.rotation = +rotation
    }

    public static void AddRotaY(this Transform transform, float rot)
    {
        Quaternion rotation = transform.rotation;
        rotation.y = rot;
        transform.rotation = +rotation;
    }

    public static void AddRotaZ(this Transform transform, float rot)
    {
        Quaternion rotation = transform.rotation;
        rotation.z = rot;
        transform.rotation = +rotation;
    }
    public static void SetRandomPos(this Transform transform)
    {
        transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
    }

    public static void SetRandomPos(this Transform transform, Vector3 minVal, Vector3 maxVal)
    {
        transform.position = new Vector3(Random.Range(minVal.x, maxVal.x), Random.Range(minVal.y, maxVal.y), Random.Range(minVal.z, maxVal.z));
    }

    public static void SetRandomRot(this Transform transform)
    {
        transform.rotation = new Quaternion(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
    }

    public static void SetRandomRot(this Transform transform, Quaternion minVal, Quaternion maxVal)
    {
        transform.rotation = new Quaternion(Random.Range((minVal.x, maxVal.x), Random.Range((minVal.y, maxVal.y), Random.Range(minVal.z, maxVal.z));

    }

    public static void AddRandomPos(this Transform transform)
    {
        transform.position = transform.position + new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
    }

    public static void AddRandomPos(this Transform transform, Vector3 minVal, Vector3 maxVal)
    {
        transform.position = transform.position + new Vector3(Random.Range(minVal.x, maxVal.x), Random.Range(minVal.y, maxVal.y), Random.Range(minVal.z, maxVal.z));
    }

    public static void AddRandomRot(this Transform transform)
    {
        transform.rotatio = transform.rotation + new Quaternion(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
    }

    public static void AddRandomRot(this Transform transform, Quaternion minVal, Quaternion maxVal)
    {
        transform.rotation = transform.rotation + new Quaternion(Random.Range((minVal.x, maxVal.x), Random.Range((minVal.y, maxVal.y), Random.Range(minVal.z, maxVal.z));
    }
    

    #endregion
}