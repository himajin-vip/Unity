
public class Equip
{
  public Weapon weapon{get; private set;} = new Weapon();
  public Head head{get; private set;} = new Head();
  public Body body{get; private set;} = new Body();
  public Hand hand{get; private set;} = new Hand();
  public Foot foot{get; private set;} = new Foot();
  public Accessory accessory{get; private set;} = new Accessory();

  public void Weapon(int itemNo){
    if(weapon.ItemId != 9999){
      weapon.UnSet(weapon.ItemId);
            weapon.Set(itemNo);
    }else{
      weapon.Set(itemNo);
    }
  }
  public void Head(int itemNo){
    if(head.ItemId != 9999){
      head.UnSet(head.ItemId);
      head.Set(itemNo);
    }else{
      head.Set(itemNo);
    }
  }
  public void Body(int itemNo){
    if(body.ItemId != 9999){
      body.UnSet(body.ItemId);
      body.Set(itemNo);
    }else{
      body.Set(itemNo);
    }
  }
  public void Hand(int itemNo){
    if(hand.ItemId != 9999){
      hand.UnSet(hand.ItemId);
      hand.Set(itemNo);
    }else{
      hand.Set(itemNo);
    }
  }
  public void Foot(int itemNo){
    if(foot.ItemId != 9999){
      foot.UnSet(foot.ItemId);
      foot.Set(itemNo);
    }else{
      foot.Set(itemNo);
    }
  }
  public void Accessory(int itemNo){
    if(accessory.ItemId != 9999){
      accessory.UnSet(accessory.ItemId);
      accessory.Set(itemNo);
    }else{
      accessory.Set(itemNo);
    }
  }
}
