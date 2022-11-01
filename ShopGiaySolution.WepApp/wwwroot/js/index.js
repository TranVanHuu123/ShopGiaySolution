

/// dang ky
function Validator(options){

    function getParent(element,selector){
        while(element.parentElement){
            if(element.parentElement.matches(selector)){
                return element.parentElement;
            }
            element=element.parentElement;
        }
    }
    var selectorRule={};

    function validate(inputElement,rule){
        var erroElement = getParent(inputElement,options.formGroupSelector).querySelector(options.errorSelector);
        var erroMessage;
//                     //lay ra cac rule cua selector
        var rules= selectorRule[rule.selector];
//                     //lap qua tung rule va kiem tra 
//                     //neu có lỗi thì dừng
        for (let index = 0; index < rules.length; index++) {
            switch(inputElement.type){
                case'radio':
                case'checkbox':
                  erroMessage =rules[index](inputElement.value)

                 break;
                default:
            erroMessage =rules[index](inputElement.value)

            }
            erroMessage =rules[index](inputElement.value)
            if(erroMessage)break;
        }
                    
        if (erroMessage){
            erroElement.innerText=erroMessage;
            getParent(inputElement,options.formGroupSelector).classList.add('invalid');
        }
        else{
            erroElement.innerText='';
            getParent(inputElement,options.formGroupSelector).classList.remove('invalid');
        }
        return !erroMessage;
    }  
    var formElement = document.querySelector(options.form);
    if (formElement) {
        //submit form
        formElement.onsubmit=function(e){
         e.preventDefault();

          var isFormValid=true;
         //lặp qua từng rule và validate
         options.rules.forEach(function(rule){
            var inputElement = formElement.querySelector(rule.selector);
            var isValid= validate(inputElement,rule);       
            if(!isValid){
                isFormValid=false;
            }
         });
        

       
         if(isFormValid){
            //trường hợp submit với java script
           if(typeof options.onSubmit === 'function'){
                var enableInputs=formElement.querySelectorAll('[name]:not([disable])');
                var formValue=Array.from(enableInputs).reduce(function(value,input){
                    value[input.name]=input.value; 
                    return value;
                },{});               
                options.onSubmit(formValue)          
           }
           //trường hợp submit với hành vi mặt định
           else{
            formElement.submit();
           }
         }
        }
        options.rules.forEach(function (rule) {
             //luu lai cac rule trong input
            if(Array.isArray(selectorRule[rule.selector])){
                selectorRule[rule.selector].push(rule.test)
            }else
            {
                selectorRule[rule.selector]=[rule.test]
            }

            var inputElement = formElement.querySelector(rule.selector);
            
            if(inputElement){
                inputElement.onblur=function (){
                    // xử lý trường hợp  blur ra ngoài
                   validate(inputElement,rule);       
                }
                //xử lý trường hợp người dùng nhập
                inputElement.oninput=function(){
                    var erroElement = getParent(inputElement,options.formGroupSelector).querySelector(options.errorSelector);     
                    erroElement.innerText='';
                    getParent(inputElement,options.formGroupSelector).classList.remove('invalid');
                }
            }
        });
    }
}
//định nghĩa rules
Validator.isRequired = function (selector){
    return {
        selector:selector,
        test: function(value){
            return value.trim() ? undefined : ' Vui lòng nhập trường này'
        }
    }
}
Validator.isEmail=function(selector){
    return {
        selector:selector,
        test: function(value){
            var regex =/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/
            return regex.test(value) ? undefined :'Trường này phải là email'
        }
    }
}
Validator.minLenght=function(selector,min){
    return {
        selector:selector,
        test: function(value){
    
            return value.length >= min ? undefined :`Vui lòng nhập tối thiểu ${min} ký tự`;
        }
    }
}
Validator.isConfirmed=function(selector,getConfirmValue,message){
    return{
        selector:selector,
        test: function(value){
            return value === getConfirmValue() ? undefined :message||'Gía trị nhập vào không chính xác'
        }
    }
}
   




