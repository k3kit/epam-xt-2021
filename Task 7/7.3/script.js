class Service{
    constructor(name, description){
        this.name = name;
        this.description = description;
        this.id = 1;
        this.list = [];
    };

    add(object){

        if(typeof object == 'object')
        {
            if(object.name === '' || object.description === ''){
                console.log("Error")
            }
            else{
                object.id = (this.list.length + 1).toString();
                this.list.push(object);
            }
        }
        else
        {
            console.log("Error");
        }
    } 


    getById(item){

        item = item.toString();

        var requiredItem = this.list.find(service => service.id === item);
        if(requiredItem)
        {
            console.log(` ${requiredItem.id} ${requiredItem.name} ${requiredItem.description}`);
            return requiredItem;
        }
        else
        {
            return null;
        }
    }


    getAll(){

        if(!!this.list.length)
        {
            for (var i in this.list)
            {
                console.log(`${this.list[i].id} ${this.list[i].name}  ${this.list[i].description}`);
            }

            return this.list;
        }
        else
        {
            console.log('Array is empty');
        }
    }


    deleteId(item){

        item = item.toString();

        var requiredItem = this.list.find(storage => storage.id === item);

        if(requiredItem){

            this.list.forEach((storage, index) => {
            if(storage.id === item)
            {
                var result = this.getById(item);
                delete this.list[index];
                return result;
            }
            });
        }
        else
        {
            console.log('Error');
        }
    }


    updateById(item, object){

        item = item.toString();

        if(typeof object == 'object')
        {
            for (var i = 0; i < this.list.length; i++)
            {
                if(this.list[i].id === item)
                {
                    this.list[i].name = object.name;
                    this.list[i].description = object.description;
                }
            }
        }
        else
        {
            console.log("Error");
        }
    }

    
    replaceById(item, object){

        item = item.toString();

        if(typeof object == 'object')
        {
            this.list.forEach((service,index) => {
                if(service.id === item)
                {
                    object.id = item;
                    this.list.splice(index, 1, object);
                }
            });
        }
        else
        {
            console.log("Error");
        }
    }   
}



