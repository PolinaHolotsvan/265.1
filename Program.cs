//поружено принцип єдиного обов’язку
class Item
{

}
class Order
{
    private List<Item> itemList;
    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
    }
    public void PrintOrder() {/*...*/}
    public void ShowOrder() {/*...*/}
    
}
class Calculate
{
    public void CalculateTotalSum() {/*...*/}
}
class ManageOrder
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}
}
class ManageItems{
    public void GetItems() {/*...*/}
    public void GetItemCount() {/*...*/}
    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
}