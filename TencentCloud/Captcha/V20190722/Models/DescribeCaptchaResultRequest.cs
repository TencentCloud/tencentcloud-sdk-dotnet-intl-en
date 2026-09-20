/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCaptchaResultRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Fixed value: 9.</p>
        /// </summary>
        [JsonProperty("CaptchaType")]
        public ulong? CaptchaType{ get; set; }

        /// <summary>
        /// <p>User verification ticket returned by the frontend callback function</p>
        /// </summary>
        [JsonProperty("Ticket")]
        public string Ticket{ get; set; }

        /// <summary>
        /// <p>Public network IP of the verification</p>
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// <p>Random string returned by the frontend callback function</p>
        /// </summary>
        [JsonProperty("Randstr")]
        public string Randstr{ get; set; }

        /// <summary>
        /// <p>Captcha appId. Log in to the <a href="https://console.cloud.tencent.com/captcha/graphical">verification code console</a>. In the [Key] column of the verification list, you can see CaptchaAppId.</p>
        /// </summary>
        [JsonProperty("CaptchaAppId")]
        public ulong? CaptchaAppId{ get; set; }

        /// <summary>
        /// <p>Captcha application key. Log in to the <a href="https://console.cloud.tencent.com/captcha/graphical">verification code console</a>, and view AppSecretKey in the [Key] column of the verification list. AppSecretKey is a key for server-side verification of verification code tickets. Keep it confidential and do not leak it to third parties.</p>
        /// </summary>
        [JsonProperty("AppSecretKey")]
        public string AppSecretKey{ get; set; }

        /// <summary>
        /// <p>Reserved field</p>
        /// </summary>
        [JsonProperty("BusinessId")]
        public ulong? BusinessId{ get; set; }

        /// <summary>
        /// <p>Reserved field</p>
        /// </summary>
        [JsonProperty("SceneId")]
        public ulong? SceneId{ get; set; }

        /// <summary>
        /// <p>mac address or unique device identifier</p>
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// <p>Mobile device number</p>
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// <p>Whether to return the time when the frontend obtains the verification code. Value: 1: need to return</p>
        /// </summary>
        [JsonProperty("NeedGetCaptchaTime")]
        public long? NeedGetCaptchaTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaptchaType", this.CaptchaType);
            this.SetParamSimple(map, prefix + "Ticket", this.Ticket);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "Randstr", this.Randstr);
            this.SetParamSimple(map, prefix + "CaptchaAppId", this.CaptchaAppId);
            this.SetParamSimple(map, prefix + "AppSecretKey", this.AppSecretKey);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "SceneId", this.SceneId);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "NeedGetCaptchaTime", this.NeedGetCaptchaTime);
        }
    }
}

