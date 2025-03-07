/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAICallRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID (required) can be found at https://console.cloud.tencent.com/ccc.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Called number.
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// ## Identity
        /// You are Kate from the appointment department at Retell Health calling Cindy over the phone to prepare for the annual checkup coming up. You are a pleasant and friendly receptionist caring deeply for the user. You don't provide medical advice but would use the medical knowledge to understand user responses.
        /// 
        /// ## Style Guardrails
        /// Be Concise: Respond succinctly, addressing one topic at most.
        /// Embrace Variety: Use diverse language and rephrasing to enhance clarity without repeating content.
        /// Be Conversational: Use everyday language, making the chat feel like talking to a friend.
        /// Be Proactive: Lead the conversation, often wrapping up with a question or next-step suggestion.
        /// Avoid multiple questions in a single response.
        /// Get clarity: If the user only partially answers a question, or if the answer is unclear, keep asking to get clarity.
        /// Use a colloquial way of referring to the date (like Friday, January 14th, or Tuesday, January 12th, 2024 at 8am).
        /// 
        /// ## Response Guideline
        /// Adapt and Guess: Try to understand transcripts that may contain transcription errors. Avoid mentioning "transcription error" in the response.
        /// Stay in Character: Keep conversations within your role's scope, guiding them back creatively without repeating.
        /// Ensure Fluid Dialogue: Respond in a role-appropriate, direct manner to maintain a smooth conversation flow.
        /// 
        /// ## Task
        /// You will follow the steps below, do not skip steps, and only ask up to one question in response.
        /// If at any time the user showed anger or wanted a human agent, call transfer_call to transfer to a human representative.
        /// 1. Begin with a self-introduction and verify if callee is Cindy.
        ///   - if callee is not Cindy, call end_call to hang up, say sorry for the confusion when hanging up.
        ///   - if Cindy is not available, call end_call politely to hang up, say you will call back later when hanging up.
        /// 2. Inform Cindy she has an annual body check coming up on April 4th, 2024 at 10am PDT. Check if Cindy is available.
        ///   - If not, tell Cindy to reschedule online and jump to step 5.
        /// 3. Ask Cindy if there's anything that the doctor should know before the annual checkup.
        ///   - Ask followup questions as needed to assess the severity of the issue, and understand how it has progressed.
        /// 4. Tell Cindy to not eat or drink that day before the checkup. Also tell Cindy to give you a callback if there's any changes in health condition.
        /// 5. Ask Cindy if she has any questions, and if so, answer them until there are no questions.
        ///   - If user asks something you do not know, let them know you don't have the answer. Ask them if they have any other questions.
        ///   - If user do not have any questions, call function end_call to hang up.
        /// </summary>
        [JsonProperty("SystemPrompt")]
        public string SystemPrompt{ get; set; }

        /// <summary>
        /// Model interface protocol types, currently compatible with three protocol types:
        /// 
        /// - OpenAI protocol (including GPT, DeepSeek, etc.):"openai"
        /// - Azure protocol:"azure"
        /// - Minimax protocol:"minimax"
        /// </summary>
        [JsonProperty("LLMType")]
        public string LLMType{ get; set; }

        /// <summary>
        /// Model name, such as
        /// 
        /// - OpenAI protocol
        /// "gpt-4o-mini","gpt-4o","deepseek-chat";
        /// 
        /// - Azure protocol
        /// "gpt-4o-mini", "gpt-4o";
        /// 
        /// - Minimax protocol
        /// "deepseek-chat".
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// Model API key, for authentication information, please refer to the respective model's official website
        /// 
        /// - OpenAI protocol: [GPT](https://help.openai.com/en/articles/4936850-where-do-i-find-my-openai-api-key), [DeepSeek](https://api-docs.deepseek.com/zh-cn/);
        /// 
        /// - Azure protocol: [Azure GPT](https://learn.microsoft.com/en-us/azure/ai-services/openai/chatgpt-quickstart?tabs=command-line%2Ctypescript%2Cpython-new&pivots=programming-language-studio#key-settings);
        /// 
        /// - Minimax:[Minimax](https://platform.minimaxi.com/document/Fast%20access?key=66701cf51d57f38758d581b2)
        /// </summary>
        [JsonProperty("APIKey")]
        public string APIKey{ get; set; }

        /// <summary>
        /// Model interface address
        /// 
        /// - OpenAI protocol
        /// GPT:"https://api.openai.com/v1/"
        /// Deepseek:"https://api.deepseek.com/v1"
        /// 
        /// - Azure protocol
        ///  "https://{your-resource-name}.openai.azure.com?api-version={api-version}"
        /// 
        /// - Minimax protocol
        /// "https://api.minimax.chat/v1"
        /// </summary>
        [JsonProperty("APIUrl")]
        public string APIUrl{ get; set; }

        /// <summary>
        /// The following voice parameter values are available by default. If you wish to customize the voice type, please leave VoiceType blank and configure it in the CustomTTSConfig parameter.
        /// 
        /// Chinese:
        /// ZhiMei: Zhimei, customer service female voice
        /// ZhiXi: Zhixi, general female voice
        /// ZhiQi: Zhiqi, customer service female voice
        /// ZhiTian: Zhitian, female child voice
        /// AiXiaoJing: Ai Xiaojing, dialogue female voice
        /// 
        /// English:
        /// WeRose:English Female Voice
        /// Monika:English Female Voice
        /// 
        /// Japanese:
        /// Nanami
        /// 
        /// Korean:
        /// SunHi
        /// 
        /// Indonesian (Indonesia):
        /// Gadis
        /// 
        /// Malay (Malaysia):
        /// Yasmin
        /// 
        ///  Tamil (Malaysia):
        /// Kani
        /// 
        /// Thai (Thailand):
        /// Achara
        /// 
        /// Vietnamese (Vietnam):
        /// HoaiMy
        /// 
        /// </summary>
        [JsonProperty("VoiceType")]
        public string VoiceType{ get; set; }

        /// <summary>
        /// Caller number list
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// Used to set the AI Agent Welcome Message.
        /// </summary>
        [JsonProperty("WelcomeMessage")]
        public string WelcomeMessage{ get; set; }

        /// <summary>
        /// 0: Use welcomeMessage (if empty, the callee speaks first; if not empty, the bot speaks first)
        /// 1:   Use AI to automatically generate welcomeMessage and speak first based on the prompt
        /// </summary>
        [JsonProperty("WelcomeType")]
        public long? WelcomeType{ get; set; }

        /// <summary>
        /// 0: interruptible by default, 1: high priority and not interruptible.
        /// </summary>
        [JsonProperty("WelcomeMessagePriority")]
        public long? WelcomeMessagePriority{ get; set; }

        /// <summary>
        /// Maximum Waiting Duration (milliseconds), default is 60 seconds, if the user does not speak within this time, the call is automatically terminated
        /// </summary>
        [JsonProperty("MaxDuration")]
        public long? MaxDuration{ get; set; }

        /// <summary>
        /// ASR Supported Languages, default is "zh" Chinese,
        /// Fill in the array with up to 4 languages, the first is the primary language for recognition, followed by optional languages,
        /// Note: When the primary language is a Chinese dialect, optional languages are invalid
        /// Currently, the supported languages are as follows. The English name of the language is on the left side of the equals sign, and the value to be filled in the Language field is on the right side, following ISO639:
        /// 1. Chinese = "zh" # Chinese
        /// 2. Chinese_TW = "zh-TW" # Taiwan (China)
        /// 3. Chinese_DIALECT = "zh-dialect" # Chinese Dialect
        /// 4. English = "en" # English
        /// 5. Vietnamese = "vi" # Vietnamese
        /// 6. Japanese = "ja" # Japanese
        /// 7. Korean = "ko" # Korean
        /// 8. Indonesia = "id" # Indonesian
        /// 9. Thai = "th" # Thai
        /// 10. Portuguese = "pt" # Portuguese
        /// 11. Turkish = "tr" # Turkish
        /// 12. Arabic = "ar" # Arabic
        /// 13. Spanish = "es" # Spanish
        /// 14. Hindi = "hi" # Hindi
        /// 15. French = "fr" # French
        /// 16. Malay = "ms" # Malay
        /// 17. Filipino = "fil" # Filipino
        /// 18. German = "de" # German
        /// 19. Italian = "it" # Italian
        /// 20. Russian = "ru" # Russian
        /// </summary>
        [JsonProperty("Languages")]
        public string[] Languages{ get; set; }

        /// <summary>
        /// Interrupt ai speaking mode. default is 0. 0 indicates automatic interruption and 1 indicates no interruption.
        /// </summary>
        [JsonProperty("InterruptMode")]
        public long? InterruptMode{ get; set; }

        /// <summary>
        /// Used when InterruptMode is 0, unit in milliseconds, default is 500ms. It means that the server-side detects ongoing vocal input for the InterruptSpeechDuration milliseconds and then interrupts.
        /// </summary>
        [JsonProperty("InterruptSpeechDuration")]
        public long? InterruptSpeechDuration{ get; set; }

        /// <summary>
        /// Whether the model supports (or enables) call_end function calling
        /// </summary>
        [JsonProperty("EndFunctionEnable")]
        public bool? EndFunctionEnable{ get; set; }

        /// <summary>
        /// Effective when EndFunctionEnable is true; the description of call_end function calling, default is "End the call when user has to leave (like says bye) or you are instructed to do so."
        /// </summary>
        [JsonProperty("EndFunctionDesc")]
        public string EndFunctionDesc{ get; set; }

        /// <summary>
        /// Whether the model supports (or enables) transfer_to_human function calling.
        /// </summary>
        [JsonProperty("TransferFunctionEnable")]
        public bool? TransferFunctionEnable{ get; set; }

        /// <summary>
        /// Takes effect when transferfunctionenable is true: transfer to human configuration.
        /// </summary>
        [JsonProperty("TransferItems")]
        public AITransferItem[] TransferItems{ get; set; }

        /// <summary>
        /// The duration after which the user hasn't spoken to trigger a notification, minimum 10 seconds, default 10 seconds
        /// </summary>
        [JsonProperty("NotifyDuration")]
        public long? NotifyDuration{ get; set; }

        /// <summary>
        /// The AI prompt when NotifyDuration has passed without the user speaking, default is "Sorry, I didn't hear you clearly. Can you repeat that?"
        /// </summary>
        [JsonProperty("NotifyMessage")]
        public string NotifyMessage{ get; set; }

        /// <summary>
        /// Maximum number of times to trigger ai prompt sound, unlimited by default.
        /// </summary>
        [JsonProperty("NotifyMaxCount")]
        public ulong? NotifyMaxCount{ get; set; }

        /// <summary>
        /// <p>And VoiceType field needs to select one, here is to use your own custom TTS, VoiceType is some built-in sound qualities</p>
        /// <ul>
        /// <li>Tencent TTS<br>
        /// For configuration, please refer to <a href="https://intl.cloud.tencent.com/document/product/1073/92668?from_cn_redirect=1#55924b56-1a73-4663-a7a1-a8dd82d6e823" target="_blank">Tencent Cloud TTS documentation link</a></li>
        /// </ul>
        /// <div><div class="v-md-pre-wrapper copy-code-mode v-md-pre-wrapper- extra-class"><pre class="v-md-prism-"><code>{
        ///     &quot;TTSType&quot;: &quot;tencent&quot;, // String TTS type, currently supports &quot;tencent&quot; and "minixmax", other vendors support in progress
        ///     &quot;AppId&quot;: &quot;Your application ID&quot;, // String required
        ///     &quot;SecretId&quot;: &quot;Your Secret ID&quot;, // String Required
        ///     &quot;SecretKey&quot;:  &quot;Your Secret Key&quot;, // String Required
        ///     &quot;VoiceType&quot;: 101001, // Integer Required, Sound quality ID, includes standard and premium sound quality. Premium sound quality is more realistic and differently priced than standard sound quality. See TTS billing overview for details. For the full list of sound quality IDs, see the TTS sound quality list.
        ///     "Speed": 1.25, // Integer Optional, speech speed, range: [-2,6], corresponding to different speeds: -2: represents 0.6x -1: represents 0.8x 0: represents 1.0x (default) 1: represents 1.2x 2: represents 1.5x 6: represents 2.5x For more precise speed control, you can retain two decimal places, such as 0.5/1.25/2.81, etc. For parameter value to actual speed conversion, refer to Speed Conversion
        ///     &quot;Volume&quot;: 5, // Integer Optional, Volume level, range: [0,10], corresponding to 11 levels of volume, default is 0, which represents normal volume.
        ///     &quot;PrimaryLanguage&quot;: 1, // Integer Optional, Primary language 1- Chinese (default) 2- English 3- Japanese
        ///     &quot;FastVoiceType&quot;: &quot;xxxx&quot;   // Optional parameter, Fast VRS parameter
        ///   }
        /// </code></pre>
        /// 
        ///   </div></div><ul>
        /// 
        /// </div></div><ul>
        /// <li>Azure TTS<br>
        /// For configuration, refer to the<a href="https://docs.azure.cn/zh-cn/ai-services/speech-service/speech-synthesis-markup-voice" target="_blank">Azure TTS documentation</a></li>
        /// </ul>
        /// <div><div class="v-md-pre-wrapper copy-code-mode v-md-pre-wrapper- extra-class"><pre class="v-md-prism-"><code>{
        ///     &quot;TTSType&quot;: &quot;azure&quot;, // Required: String TTS type
        ///     &quot;SubscriptionKey&quot;: &quot;xxxxxxxx&quot;, // Required: String subscription key
        ///     &quot;Region&quot;: &quot;chinanorth3&quot;,  // Required: String subscription region
        ///     &quot;VoiceName&quot;: &quot;zh-CN-XiaoxiaoNeural&quot;, // Required: String Timbre Name required
        ///     &quot;Language&quot;: &quot;zh-CN&quot;, // Required: String Language for synthesis
        ///     &quot;Rate&quot;: 1 // Optional: float Playback Speed 0.5-2 default is 1
        /// }
        /// </code></pre>
        /// 
        /// </div></div><ul>
        /// <li>Custom</li>
        /// </ul>
        /// <p>TTS<br>
        /// Please refer to the specific protocol standards in the <a href="https://doc.weixin.qq.com/doc/w3_ANQAiAbdAFwHILbJBmtSqSbV1WZ3L?scode=AJEAIQdfAAo5a1xajYANQAiAbdAFw" target="_blank">Tencent documentation</a></p>
        /// <div><div class="v-md-pre-wrapper copy-code-mode v-md-pre-wrapper- extra-class"><pre class="v-md-prism-"><code>{
        ///   &quot;TTSType&quot;: &quot;custom&quot;, // Required String
        ///   &quot;APIKey&quot;: &quot;ApiKey&quot;, // Required String for Authentication
        ///   &quot;APIUrl&quot;: &quot;http://0.0.0.0:8080/stream-audio&quot; // Required String, TTS API URL
        ///   &quot;AudioFormat&quot;: &quot;wav&quot;, // String, optional, expected audio format, such as mp3, ogg_opus, pcm, wav, default is wav, currently only pcm and wav are supported,
        ///   &quot;SampleRate&quot;: 16000,  // Integer, optional, audio sample rate, default is 16000 (16k), recommended value is 16000
        ///   &quot;AudioChannel&quot;: 1,    // Integer, optional, number of audio channels, values: 1 or 2, default is 1
        /// }
        /// </code></pre>
        /// 
        /// </div></div>
        /// </summary>
        [JsonProperty("CustomTTSConfig")]
        public string CustomTTSConfig{ get; set; }

        /// <summary>
        /// Prompt word variable.
        /// </summary>
        [JsonProperty("PromptVariables")]
        public Variable[] PromptVariables{ get; set; }

        /// <summary>
        /// Automatic speech recognition vad time ranges from 240 to 2000, with a default of 1000, measured in milliseconds. smaller values will make automatic speech recognition segment faster.
        /// </summary>
        [JsonProperty("VadSilenceTime")]
        public long? VadSilenceTime{ get; set; }

        /// <summary>
        /// Call content extraction configuration.
        /// </summary>
        [JsonProperty("ExtractConfig")]
        public AICallExtractConfigElement[] ExtractConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "SystemPrompt", this.SystemPrompt);
            this.SetParamSimple(map, prefix + "LLMType", this.LLMType);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "APIKey", this.APIKey);
            this.SetParamSimple(map, prefix + "APIUrl", this.APIUrl);
            this.SetParamSimple(map, prefix + "VoiceType", this.VoiceType);
            this.SetParamArraySimple(map, prefix + "Callers.", this.Callers);
            this.SetParamSimple(map, prefix + "WelcomeMessage", this.WelcomeMessage);
            this.SetParamSimple(map, prefix + "WelcomeType", this.WelcomeType);
            this.SetParamSimple(map, prefix + "WelcomeMessagePriority", this.WelcomeMessagePriority);
            this.SetParamSimple(map, prefix + "MaxDuration", this.MaxDuration);
            this.SetParamArraySimple(map, prefix + "Languages.", this.Languages);
            this.SetParamSimple(map, prefix + "InterruptMode", this.InterruptMode);
            this.SetParamSimple(map, prefix + "InterruptSpeechDuration", this.InterruptSpeechDuration);
            this.SetParamSimple(map, prefix + "EndFunctionEnable", this.EndFunctionEnable);
            this.SetParamSimple(map, prefix + "EndFunctionDesc", this.EndFunctionDesc);
            this.SetParamSimple(map, prefix + "TransferFunctionEnable", this.TransferFunctionEnable);
            this.SetParamArrayObj(map, prefix + "TransferItems.", this.TransferItems);
            this.SetParamSimple(map, prefix + "NotifyDuration", this.NotifyDuration);
            this.SetParamSimple(map, prefix + "NotifyMessage", this.NotifyMessage);
            this.SetParamSimple(map, prefix + "NotifyMaxCount", this.NotifyMaxCount);
            this.SetParamSimple(map, prefix + "CustomTTSConfig", this.CustomTTSConfig);
            this.SetParamArrayObj(map, prefix + "PromptVariables.", this.PromptVariables);
            this.SetParamSimple(map, prefix + "VadSilenceTime", this.VadSilenceTime);
            this.SetParamArrayObj(map, prefix + "ExtractConfig.", this.ExtractConfig);
        }
    }
}

