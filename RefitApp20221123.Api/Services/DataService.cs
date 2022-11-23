using RefitApp20221123.Models;

namespace RefitApp20221123.Api.Services
{
    public class DataService
    {
        public List<string> GetNumberList()
        {
            return new List<string>{
            "၃", "၁၀", "၅", "၁၀", "၇", "၂", "၅", "၂", "၇",
            "၈", "၆", "၄", "၅", "၃", "၁", "၁၀", "၈", "၆",
            "၇", "၂", "၉", "၄", "၉", "၆", "၉", "၄", "၁",
            "၈", "၅", "၁၀", "၆", "၃", "၈", "၄", "၁", "၆",
            "၃", "၁", "၉", "၁", "၉", "၇", "၉", "၇", "၅",
            "၂", "၇", "၄", "၁၀", "၅", "၂", "၈", "၃", "၁၀",
            "၇", "၄", "၉", "၂", "၉", "၄", "၉", "၆", "၁",
            "၂", "၁၀", "၈", "၇", "၅", "၃", "၄", "၂", "၁၀",
            "၁", "၆", "၃", "၆", "၁", "၈", "၃", "၈", "၅"
        };
        }

        public List<QuestionModel> GetQuestions()
        {
            return new List<QuestionModel>
        {
            new QuestionModel()
            {
                QuestionNo = 1,
                QuestionName = "ဇနီးမောင်နှံ၌ သားသမီးရကိန်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 2,
                QuestionName = "ဤပဋိသန္ဓေမှ ယောကျာ်းလေးမွေးမည်လော/ မိန်းကလေးမွေးမည်လော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 3,
                QuestionName = "ဤကိုယ်ဝန်ကို မွေးဖွားသည့်အခါ ရိုးရိုးမွေးရမည်လော/ ခွဲစိပ်၍မွေးရမည်လော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 4,
                QuestionName = "မွေးဖွားလာမည့်ကလေးသည် လူဝင်စား ဟုတ်တုံလော/ မဟုတ်တုံလော ဆိုသည်ကိုဟောသော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 5,
                QuestionName = "မွေးဖွားလာသောကလေးသည် မိဘကို အကျိုးပေးမည်လော/ မပေးမည်လောနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 6,
                QuestionName = "ထိုပဋိသန္ဓေမှ မွေးဖွားလာသည့်ကလေးသည် ပညာသင်ကြားရေး၌ ထူးချွန်မှုရှိမည်/ မရှိမည်နှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 7,
                QuestionName = "ရောဂါဖြစ်ပွားခြင်းနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 8,
                QuestionName = "ယခုစားနေသော ဆေးဝါးဓါတ်စာတို့သည် ရောဂါပျောက်ကင်းရန် အထောက်အကူပြုပါ၏လော/ မပြုပါ၏လောနှင့် ပတ်သက်သော အဟော။"
            },new QuestionModel()
            {
                QuestionNo = 9,
                QuestionName = "အရေးကြီးသော ခွဲစိပ်ကုသမှု ပြုလုပ်ရန်ရှိပါသည်။ အန္တရာယ်ကင်းခြင်း ရှိ၏/ မရှိ၏နှင့် ပတ်သက်သောအဟော။"
            },new QuestionModel()
            {
                QuestionNo = 10,
                QuestionName = "သူတစ်ပါး၏ကြွေးမြီ/ အခြားသောကြွေးမြီများ ရှိနေပါသည်။ အမြန်ဆုံး ဆပ်နိုင်ခြင်း ရှိ/မရှိနှင့် ဆိုင်သော အဟော။"
            }
        };
        }

        public List<AnswerModel> GetAnswers()
        {
            return new List<AnswerModel>{
            new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 1,
                    AnswerResult = "ဇနီးမောင်နှံ၌ သားသမီးရကိန်းမှာ မသေချာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 2,
                    AnswerResult = "အလွန်ထူးခြားသော ပုဂ္ဂိုလ်ဖြစ်မည့် ပါရမီရှင်သားတစ်ဦး ရရှိပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 3,
                    AnswerResult = "ယောကျ်ားလေးတစ်ဦး ရရှိပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 4,
                    AnswerResult = "မိန်းမတစ်ဦးထံမှ သားသမီးရသော သတင်းကိုကြားပြီး မကြာခင်၌ သားသမီးရလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 5,
                    AnswerResult = "သားသမီးရရန် သေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 6,
                    AnswerResult = "ပါရမီရှင်တစ်ဦးသည် ဤဇနီးမောင်နှံ၌ ဝင်စားလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 7,
                    AnswerResult = "အလွန်ထူးခြားသော သားသမီးကို ရပေလိမ့်မည်။ သားသမီးရပြီးနောက် ဤဇနီးမောင်နှံ ချမ်းသာလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 8,
                    AnswerResult = "သားသမီးကောင်းများ ထွန်းကားပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 9,
                    AnswerResult = "မိဘကို အကျိုးပေးသော သားသမီးရရှိလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 1,
                    AnswerNo = 10,
                    AnswerResult = "ဤလောကကိုအကျိုးပြုမည့် သားကောင်းရတနာတစ်ဦး ရရှိပေလိမ့်မည်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 1,
                    AnswerResult = "ယောကျာ်းလေးမွေးမည်၊ မိန်းကလေးမွေးမည်ကို ဟောရန် အချိန်စောပါသေးသည်။ သို့ရာတွင် မွေးဖွားမည့်ကလေးမှာ အလွန်ထူးခြားသော ပါရမီရှင်ဖြစ်ကြောင်း အခုကပင် ဟောလိုက်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 2,
                    AnswerResult = "ယောကျာ်းလေးမွေးမှာ သေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 3,
                    AnswerResult = "ယောကျာ်းမွေးမည်မှာ သေချာပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 4,
                    AnswerResult = "ယောကျာ်းလေးမွေးမည်မှာ သေချာပါသည်။ ထိုယောကျာ်းလေးမှာ လွန်စွာဆိုးပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 5,
                    AnswerResult = "ယောကျာ်းပီသသော ယောကျာ်းမျိုး မွေးဖွားပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 6,
                    AnswerResult = "ယောကျာ်းလေးဖြစ်မှာ သေချာပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 7,
                    AnswerResult = "မိန်းကလေးဖြစ်ပါလိမ့်မည်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 8,
                    AnswerResult = "ဤကမ္ဘာသို့ အလည်အပတ်ရောက်ရှိလာသော ထူးခြားသည့်ပုဂ္ဂိုလ် ယောကျာ်းလေးတစ်ဦးဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 9,
                    AnswerResult = "ယောကျာ်းလေးဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 2,
                    AnswerNo = 10,
                    AnswerResult = "ယောကျာ်းလေးဖြစ်ပါလိမ့်မည်။ မွေးဖွားရ လွယ်ကူပေလိမ့်မည်။ လွန်စွာထူးခြားသော ကလေးဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 1,
                    AnswerResult = "လောလောဆယ် မပြောင်းရသေးပါဘူးဗျာ။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 1,
                    AnswerResult = "ခွဲစိပ်၍မွေးရပါမည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 2,
                    AnswerResult = "ခွဲစိပ်၍ မွေးရပါမယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 3,
                    AnswerResult = "ခွဲစိပ်ရမည်ဟု ထင်ရပါသည်။ အမှန်တကယ် မွေးသောအခါ မခွဲစိပ်ဘဲ မွေးရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 4,
                    AnswerResult = "ခွဲစိပ်၍ မွေးရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 5,
                    AnswerResult = "မခွဲမစိပ်ဘဲ မွေးရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 6,
                    AnswerResult = "မခွဲစိပ်ဘဲ မွေးဖွားရပေလိမ့်မည်။ မွေးမည့်နေ့တွင် ပန်းဝါ(၁)ပွင့်ကို မိခင်လောင်း၏ အိပ်ယာဘေးတွင် ပန်းအိုးဖြင့်ထိုးထားပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 7,
                    AnswerResult = "ခွဲစိပ်၍မွေးရမည်မဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 8,
                    AnswerResult = "ခွဲစိပ်ခြင်းမပြုရဘဲ မွေးပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 9,
                    AnswerResult = "ခွဲစိပ်မွေးဖွားရပေလိမ့်မည်။ သို့သော် လွယ်လွယ်ကူကူ မွေးပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 3,
                    AnswerNo = 10,
                    AnswerResult = "ခွဲစိပ်မွေးရန်မလိုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 1,
                    AnswerResult = "မွေးဖွားလာသော ကလေးမှာ လူဝင်စားဖြစ်ပါသည်။ မြစ်၀ကျွန်းပေါ် အရပ်ဒေသမှ ဖြစ်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 2,
                    AnswerResult = "လူဝင်စားဖြစ်ပါတယ်။ ချမ်းသာသောဘ၀မှ ရောက်ရှိလာသူဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 3,
                    AnswerResult = "လူဝင်စားတစ်ဦးဖြစ်ပါတယ်။ အောင်မြင်ချမ်းသာသော လူတစ်ဦး ပြန်လည်ဝင်စားခြင်းဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 4,
                    AnswerResult = "လူဝင်စားတစ်ဦးဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 5,
                    AnswerResult = "လူဝင်စားဖြစ်ပါသည်။ လွန်စွာမှ ချမ်းသာသူတစ်ဦး ဝင်စားခြင်းဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 6,
                    AnswerResult = "လူဝင်စားဟု မပြောနိုင်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 7,
                    AnswerResult = "လူဝင်စားတစ်ဦးဖြစ်ပါတယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 8,
                    AnswerResult = "လူဝင်စားဟု မပြောနိုင်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 9,
                    AnswerResult = "သင်ထင်သကဲ့သို့ လူဝင်စားမဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 4,
                    AnswerNo = 10,
                    AnswerResult = "လူဝင်စားဟု မပြောနိုင်ပါ။ သင်ထင်နေသောသူ ပြန်လည်ဝင်စားခြင်းမဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 1,
                    AnswerResult = "မိဘကို လွန်စွာအကျိုးပေးမည့် သားသမီးဖြစ်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 2,
                    AnswerResult = "မိဘကို ကောင်းစွာ အကျိုးပေးပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 3,
                    AnswerResult = "မိဘကို အကျိုးပေးလိမ့်မည် မဟုတ်ပါ။ အရွယ်ရောက်သည်နှင့် သူ့လမ်းသူ သွားလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 4,
                    AnswerResult = "မိဘကို လွန်စွာ အကျိုးပေးပေလိမ့်မည်။ ထို့အပြင် မိဘမှာ သူ့ကြောင့်များစွာ ဂုဏ်ရှိပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 5,
                    AnswerResult = "မိဘကို ကောင်းစွာအကျိုးပေးမည့် ကလေးဖြစ်သည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 6,
                    AnswerResult = "မိဘကို ကောင်းစွာအကျိုးပေးသည့်အပြင် ကောင်းစွာလည်း စောင့်ရှောက်ပေးလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 7,
                    AnswerResult = "မိဘကို အကျိုးပေးမည့်သားသမီးဖြစ်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 8,
                    AnswerResult = "ဤကလေးလောက် မိဘကို အကျိုးပေးမည့်ကလေး ရှိမည်မဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 9,
                    AnswerResult = "မိဘကို အကျိုးပေးလိမ့်မည်မဟုတ်ပါ။ အရွယ်ရောက်သည်နှင့် သူ့လမ်းသူသွားပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 5,
                    AnswerNo = 10,
                    AnswerResult = "မိဘကိုအကျိုးပြုမည်မဟုတ်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 1,
                    AnswerResult = "ဤကလေးသည် ပညာသင်ကြားရေး၌ အနည်းငယ် အခက်အခဲ တွေ့ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 2,
                    AnswerResult = "ဤကလေးမှာ ပညာရေးအတွက် မိဘက များစွာထိန်းကျောင်းပေးရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 3,
                    AnswerResult = "ဤကလေးသည် ပညာရေး၌ ထူးချွန်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 4,
                    AnswerResult = "ဤကလေးသည် ပညာရေး၌ များစွာထူးချွန်လိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 5,
                    AnswerResult = "ဤကလေးသည် ပညာသင်ကြားရာ၌ မိဘကများစွာ ထိန်းကျောင်းပေးရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 6,
                    AnswerResult = "ဤကလေးသည် ပညာသင်ကြားရေး၌ ထူးချွန်ရန် မိဘကများစွာ ကြည့်ရှုရပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 7,
                    AnswerResult = "ဤကလေးသည် ပညာသင်ကြားရေး၌ ထူးချွန်သောကလေး မုချဖြစ်လိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 8,
                    AnswerResult = "ဤကလေးသည် ပညာရေး၌ ထူးချွန်မည့် ကလေးဖြစ်သည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 9,
                    AnswerResult = "ဤကလေးသည် ပညာရေး၌ မုချထူးချွန်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 6,
                    AnswerNo = 10,
                    AnswerResult = "ဤကလေးသည် ပညာရေး၌ ထူးချွန်ရန် မိဘကများစွာ ကြပ်မတ်ရလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 1,
                    AnswerResult = "အခုဖြစ်ပွားနေသော ရောဂါမှာ အသေးအဖွဲမျှသာဖြစ်သည်။ မကြာခင် ပျောက်ကင်းသွားလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 2,
                    AnswerResult = "ယခုဖြစ်ပွားသောရောဂါမှာ အကြိတ်အနယ် ကုသရပေလိမ့်မယ်။ သို့ရာတွင် ပျောက်ကင်းချမ်းသာသွားပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 2,
                    AnswerResult = "ကျိန်းသေနိုင်မှာပါ။ ငှက်လွှတ်တဲ့ကုသိုလ် လုပ်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 3,
                    AnswerResult = "ဖြစ်ပွားနေသောရောဂါမှာ မကြာခင် ပျောက်ကင်းသွားပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 4,
                    AnswerResult = "ဖြစ်ပွားနေသောရောဂါမှာ ငွေကုန်ချင်ကုန်မည်။ (သို့မဟုတ်) လူပင်ပန်းလျှင် ပင်ပန်းမည်။ သို့သော် ပျောက်ကင်းပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 5,
                    AnswerResult = "ယခုဖြစ်ပွားနေသော ရောဂါမှာ မကြာခင်ပျောက်ပေလိမ့်မည်။ (သို့မဟုတ်) ခရီးတစ်ခုသွားလိုက်လျှင် ပျောက်သွားပေလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 6,
                    AnswerResult = "ယခုဖြစ်ပွားနေသောရောဂါမှာ စိုးရိမ်စရာမရှိပါ။ မကြာခင်ပျောက်ကင်းသွားပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 7,
                    AnswerResult = "ယခုဖြစ်ပွားနေသောရောဂါမှာ အသားညိုညို ဆေးဆရာ (သို့) ဆရာဝန်နှင့် ကုလျှင် ပျောက်ကင်းပေလိမ့်မည်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 8,
                    AnswerResult = "ယခုဖြစ်ပွားနေသော ရောဂါမှာ ကြောင်နက်ကို အစာကြွေးလိုက်ပါ။ ပန်းဝါ(၁)ပွင့် ဘုရားကိုလှူလိုက်ပါ။ တောင်ဝှေး(၁)ချောင်း ဘုန်းကြီးတစ်ပါးကိုလှူပါ။ ဤသို့ပြုလုပ်လျှင် ပျောက်ကင်းသွားပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 9,
                    AnswerResult = "ယခုဖြစ်ပွားနေတဲ့ရောဂါမှာ မကြာခင်ပျောက်ကင်းသွားပေလိမ့်မည်။ အသိမိတ်ဆွေတစ်ဦး မင်္ဂလာဆောင်တဲ့သတင်းကြားရလျှင် ထိုထက်မြန်မြန် ပျောက်ကင်းသွားပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 7,
                    AnswerNo = 10,
                    AnswerResult = "ရောဂါပျောက်ကင်းချိန် တန်ပါပြီ။ ထိုရောဂါပျောက်ကင်းပြီးနောက် သင်လည်းစီးပွားရေး မုချကောင်းသွားပါလိမ့်မယ်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 1,
                    AnswerResult = "ယခုမှီဝဲနေသော ဆေးဝါးဓါတ်စာတို့မှာ ရောဂါပျောက်ကင်းသွားရန် များစွာအထောက်အကူပြုပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 2,
                    AnswerResult = "ယခုမှီဝဲနေသော ဆေးဝါးဓါတ်စာတို့မှာ ရောဂါပျောက်ရန်အတွက် များစွာ အထောက်အကူပြုပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 3,
                    AnswerResult = "ဆေးဝါးဓါတ်စာတို့ကို ရပ်ဝေးမှ ဝယ်ယူမှီဝဲလျှင် ပို၍ကောင်းပါသည်။ ရောဂါလည်း ပျောက်ပါမည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 4,
                    AnswerResult = "ဆေးဝါးဓါတ်စာတို့ကို လူငယ်တစ်ဦးအား ဝယ်ခိုင်းပြီး မှ မှီဝဲခိုင်းလျှင် ပို၍အပျောက်မြန်ပေလိမ့်မည်၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 5,
                    AnswerResult = "အသားမည်းမည်းလူတစ်ယောက်က ဝယ်ခိုင်းသော ဆေးဝါးဓါတ်စာများဖြစ်ပါက ရောဂါပျောက်ရန်ပို၍ မြန်ပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 6,
                    AnswerResult = "ယခုမှီဝဲနေသော ဆေးဝါးဓါတ်စာတို့သည် ရောဂါပျောက်ကင်းရန် များစွာအထောက်အကူပြုပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 7,
                    AnswerResult = "မင်္ဂလာဆောင်ပြီးစ လူတစ်ဦးအား ဝယ်ခိုင်းသော ဆေးဝါးဓါတ်စာများဖြစ်ပါက ရောဂါချက်ချင်းပျောက်ကင်းသွားပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 8,
                    AnswerResult = "ဤဆေးဝါးဓါတ်စာများသည် ရောဂါပျောက်ကင်းရုံမျှမက ဓါတ်ရိုက်သကဲ့သို့ဖြစ်ပြီး ချမ်းသာသွားလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 9,
                    AnswerResult = "ဤဆေးဝါးဓါတ်စာများသည် နတ်ဆေး၊ နတ်ဝါးများကဲ့သို့ အစွမ်းပြပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 8,
                    AnswerNo = 10,
                    AnswerResult = "ဤဆေးဝါးဓါတ်စာများ မှီဝဲပြီးသည်နှင့် တစ်ပြိုင်နက် သိသာပေလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 1,
                    AnswerResult = "ခွဲစိတ်ကုသမှုမှာ အန္တရာယ်မရှိပါ။ မုချအောင်မြင်ပါလိမ့်မည်၊၊ အန္တရာယ်လည်းကင်းပါသည်၊၊ ရေကန်နှစ်ကန်မှရေကို ဖန်ခွက်ထဲထည့်၍ မြတ်စွာဘုရားကိုကပ်လှူပါ၊၊"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 2,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ အရေးကြီးသောကြောင့် ကျွမ်းကျင်သောဆရာဝန်ကို အတိကျ လေ့လာရန် အရေးကြီးပါသည်။ နွားနို့(၄)ခွက် လှူလိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 3,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ ချောမောစွာ အောင်မြင်ပါသည်။ အန္တရာယ်မရှိပါ။ မပြုလုပ်မီ၌ ငှက်လွှတ်ပေးသော ကုသိုလ်ကို ပြုလုပ်ပေးပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 4,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ အရေးကြီးပါတယ်။ အန္တရာယ်မရှိဟု ဆိုသော်လည်း ခွဲစိပ်ဆရာဝန်အဖို့ ကြိုးပမ်းရမည့်ကိစ္စ ဖြစ်ပါသည်။ အမွှေးတိုင်(၈)တိုင် ဘုရားလှူပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 5,
                    AnswerResult = "ကယ်ဖြစ်အောင် ကယ်လိုက်စမ်းပါဗျာ။ ကျေးဇူးကန်းတယ်ဆိုတာ လွယ်တဲ့အလုပ်မဟုတ်ဘူးဗျ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 5,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ အရေးကြီးပါသည်။ ဘုရားစင်ရှေ့မှာ ဓါးတစ်စချောင်းထောင်ထားပါ။ အောင်မြင်ပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 6,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ ချောမွေ့စွာ အောင်မြင်ပါလိမ့်မည်။ ခွဲစိပ်မည့် ဆရာဝန်မှာ အလွန်ကျွမ်းကျင်ပါသည်။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 7,
                    AnswerResult = "ခွဲစိတ်ကုသမှုမှာ ချောမွေ့စွာ အောင်မြင်သွားပေလိမ့်မည်။ စိုးရိမ်စရာမရှိပါ။ ခွဲစိပ်ဆရာဝန်မှာ ကောင်းကင်မှ လွှတ်လိုက်သောသူဖြစ်ပါသည်။ ဘာမှပူစရာမလိုပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 8,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ စိုးရိမ်စရာမရှိပါ။ အောင်မြင်ပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 9,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ လုံး၀စိုးရိမ်စရာမလိုပါ။ မယ်တော်များကို ဖယောင်းတိုင်(၂)တိုင်ထွန်း၍ တိုင်တည်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 9,
                    AnswerNo = 10,
                    AnswerResult = "ခွဲစိပ်ကုသမှုမှာ စိုးရိမ်စရာမရှိပါ။ ကမ္ဘာကြီးမှာ တိုးတက်နေပြီဖြစ်၍ ဤခွဲစိပ်ကုသမှုမှာ ထမင်းစားရေသောက်ဖြစ်ပါသည်။ ဖယောင်းတိုင်နှစ်တိုင်ထွန်း၍ မယ်တော်တစ်ပါးပါးကို တိုင်တည်လိုက်ပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 1,
                    AnswerResult = "အကြွေးအတွက် မပူပါနဲ့။ နည်းနည်းလေးကြိုးစားပြီးတော့ ဆပ်ရမှာပါ။ ကြေသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 2,
                    AnswerResult = "ကြွေးကဘယ်လောက်များများ ကျန်သေးလို့လဲ။ မပူပါနဲ့။ သူ့နည်းသူ့ဟန်နဲ့ ကြေသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 3,
                    AnswerResult = "ကြွေးဆပ်မယ်လို့ အာရုံပြုထားပါ။ ဒီအတွက်တော့မပူပါနဲ့၊ ကြေသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 4,
                    AnswerResult = "ဓါတ်ရိုက်တဲ့အနေနဲ့ လမ်းထဲက အသားမည်းမည်းကလေးတစ်ယောက်ကို အိမ်မှာခေါ်ပြီး ထမင်းတစ်ခါလောက် ကျွေးလိုက်စမ်းပါ။ သူ့အကြွေးတွေကြောင့် နည်းလမ်းပေါ်လာမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 5,
                    AnswerResult = "ဒီအချိန်လေး အကြပ်အတည်း တွေ့နေတာပါ။ သင့်ရဲ့အကြွေးတွေကို သင်ကိုယ်တိုင်ဆပ်ဖို့ မလိုပါဘူး။ ကောင်းကင်ဘုံက ဆပ်ပေးပါလိမ့်မည်။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 6,
                    AnswerResult = "သင့်ရဲ့အကြွေးတွေအတွက် ဘာဖြစ်နေတာလဲ။ အိမ်နားမှာ မိန်းမတစ်ယောက် ကလေးမျက်နှာမြင်တဲ့ နိမိတ်ပေါ်ပြီးရင် သင့်ရဲ့အကြွေးတွေ တစ်ပြားမကျန် ကြေသွားမှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 7,
                    AnswerResult = "သင့်အကြွေးတွေအတွက် မပူပါနဲ့။ မကြာခင်ဆပ်နိုင်မှာပါ။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 8,
                    AnswerResult = "ပျော်ပျော်နေစမ်းပါ။ ကြွေးတွေကို ခေါင်းထဲမထည့်ပါနဲ့။ ကြေသွားမှာပါ။ မကြေလည်း ဘာမှမဖြစ်ပါဘူး။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 9,
                    AnswerResult = "ကြွေးအကြောင်းသိချင်လို့လား။ မမေးပါနဲ့။ ကြေပြီလို့သာ မှတ်လိုက်ပါတော့။"
                },new AnswerModel()
                {
                    QuestionNo = 10,
                    AnswerNo = 10,
                    AnswerResult = "ကြွေးကြေရုံမဟုတ်ပါဘူး။ အိမ်တစ်လုံ ထပ်ပြီးဝယ်နိုင်ဦးမှာပါ။"
                }
            };
        }
    }
}
