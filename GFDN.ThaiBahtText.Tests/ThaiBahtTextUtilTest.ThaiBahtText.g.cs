using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreatFriends.ThaiBahtText;
// <copyright file="ThaiBahtTextUtilTest.ThaiBahtText.g.cs" company="GreatFriends.Biz">Copyright ©  2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace GreatFriends.ThaiBahtText.Tests
{
  public partial class ThaiBahtTextUtilTest {

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText80()
{
    string s;
    s = this.ThaiBahtText(default(decimal), UsesEt.TensOnly, Unit.Baht, 0, false);
    Assert.AreEqual<string>("ศูนย์บาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText638()
{
    string s;
    s = this.ThaiBahtText(default(decimal), UsesEt.TensOnly, Unit.Baht, 0, true);
    Assert.AreEqual<string>("ศูนย์บาทถ้วน", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText496()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, Unit.Baht, 0, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามบาทหกสิบห้าสตางค์", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText796()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.Always, Unit.Baht, 0, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามบาทหกสิบห้าสตางค์", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText692()
{
    string s;
    s = this.ThaiBahtText(-76819052936496198642298613574e-19M, UsesEt.TensOnly, 
                          Unit.Million, 0, false);
    Assert.AreEqual<string>("ลบเจ็ดพันหกร้อยแปดสิบสองล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText576()
{
    string s;
    s = this.ThaiBahtText(default(decimal), UsesEt.TensOnly, Unit.Million, 0, false);
    Assert.AreEqual<string>("ศูนย์ล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText370()
{
    string s;
    s = this.ThaiBahtText(-76819052936496198642298613574e-19M, UsesEt.TensOnly, 
                          Unit.Billion, 0, false);
    Assert.AreEqual<string>("ลบแปดพันล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText32()
{
    string s;
    s = this.ThaiBahtText(default(decimal), UsesEt.TensOnly, Unit.Billion, 0, false);
    Assert.AreEqual<string>("ศูนย์พันล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText585()
{
    string s;
    s = this.ThaiBahtText(-76819052936496198642298613574e-19M, UsesEt.TensOnly, 
                          Unit.Trillion, 0, false);
    Assert.AreEqual<string>("ล้านล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText564()
{
    string s;
    s =
      this.ThaiBahtText(default(decimal), UsesEt.TensOnly, Unit.Trillion, 0, false);
    Assert.AreEqual<string>("ศูนย์ล้านล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText441()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, (Unit)4, 0, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสี่", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText807()
{
    string s;
    s = this.ThaiBahtText(default(decimal), UsesEt.TensOnly, (Unit)4, 0, false);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText25()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, (Unit)4, 4, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามจุดหกสี่เก้าหก", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText869()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, (Unit)4, 6, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามจุดหกสี่เก้าหกสอง", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText816()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, (Unit)4, 5, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามจุดหกสี่เก้าหกสอง", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText127()
{
    string s;
    s = this.ThaiBahtText(-76819052936496198642298613574e-19M, UsesEt.TensOnly, 
                          Unit.Billion, 1, false);
    Assert.AreEqual<string>("ลบเจ็ดจุดเจ็ดพันล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText71()
{
    string s;
    s = this.ThaiBahtText(-76819052936496198642298613574e-19M, UsesEt.TensOnly, 
                          Unit.Billion, 2, false);
    Assert.AreEqual<string>("ลบเจ็ดจุดหกแปดพันล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText10()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, (Unit)4, 3, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามจุดหกห้า", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText800()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, (Unit)4, 7, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามจุดหกห้า", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText8001()
{
    string s;
    s = this.ThaiBahtText(default(decimal), UsesEt.TensOnly, Unit.Baht, 0, false);
    Assert.AreEqual<string>("ศูนย์บาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText63801()
{
    string s;
    s = this.ThaiBahtText(default(decimal), UsesEt.TensOnly, Unit.Baht, 0, true);
    Assert.AreEqual<string>("ศูนย์บาทถ้วน", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText49601()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, Unit.Baht, 0, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามบาทหกสิบห้าสตางค์", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText79601()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.Always, Unit.Baht, 0, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามบาทหกสิบห้าสตางค์", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText69201()
{
    string s;
    s = this.ThaiBahtText(-76819052936496198642298613574e-19M, UsesEt.TensOnly, 
                          Unit.Million, 0, false);
    Assert.AreEqual<string>("ลบเจ็ดพันหกร้อยแปดสิบสองล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText57601()
{
    string s;
    s = this.ThaiBahtText(default(decimal), UsesEt.TensOnly, Unit.Million, 0, false);
    Assert.AreEqual<string>("ศูนย์ล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText125()
{
    string s;
    s = this.ThaiBahtText(-76819052936496198642298613574e-19M, UsesEt.TensOnly, 
                          Unit.Million, 1, false);
    Assert.AreEqual<string>("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดจุดเก้าล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText37001()
{
    string s;
    s = this.ThaiBahtText(-76819052936496198642298613574e-19M, UsesEt.TensOnly, 
                          Unit.Billion, 0, false);
    Assert.AreEqual<string>("ลบแปดพันล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText804()
{
    string s;
    s = this.ThaiBahtText(-76819052936496198642298613574e-19M, UsesEt.TensOnly, 
                          Unit.Million, 2, false);
    Assert.AreEqual<string>("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดจุดเก้าหนึ่งล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText3201()
{
    string s;
    s = this.ThaiBahtText(default(decimal), UsesEt.TensOnly, Unit.Billion, 0, false);
    Assert.AreEqual<string>("ศูนย์พันล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText58501()
{
    string s;
    s = this.ThaiBahtText(-76819052936496198642298613574e-19M, UsesEt.TensOnly, 
                          Unit.Trillion, 0, false);
    Assert.AreEqual<string>("ล้านล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText56401()
{
    string s;
    s =
      this.ThaiBahtText(default(decimal), UsesEt.TensOnly, Unit.Trillion, 0, false);
    Assert.AreEqual<string>("ศูนย์ล้านล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText623()
{
    string s;
    s = this.ThaiBahtText(-76819052936496198642298613574e-19M, UsesEt.TensOnly, 
                          Unit.Billion, 3, false);
    Assert.AreEqual<string>("ลบเจ็ดจุดหกแปดสองพันล้านบาท", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText44101()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, (Unit)4, 0, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสี่", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText80701()
{
    string s;
    s = this.ThaiBahtText(default(decimal), UsesEt.TensOnly, (Unit)4, 0, false);
    Assert.AreEqual<string>("", s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText2501()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, (Unit)4, 4, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามจุดหกสี่เก้าหก", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText86901()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, (Unit)4, 6, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามจุดหกสี่เก้าหกสอง", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText81601()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, (Unit)4, 5, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามจุดหกสี่เก้าหกสอง", 
         s);
}

[TestMethod]
[PexGeneratedBy(typeof(ThaiBahtTextUtilTest))]
public void ThaiBahtText80001()
{
    string s;
    s = this.ThaiBahtText
            (-76819052936496198642298613574e-19M, UsesEt.TensOnly, (Unit)4, 7, false);
    Assert.AreEqual<string>
        ("ลบเจ็ดพันหกร้อยแปดสิบเอ็ดล้านเก้าแสนห้าพันสองร้อยเก้าสิบสามจุดหกห้า", s);
}
  }
}
