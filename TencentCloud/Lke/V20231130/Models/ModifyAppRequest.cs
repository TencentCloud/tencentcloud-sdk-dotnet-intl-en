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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAppRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID.
        /// </summary>
        [JsonProperty("AppBizId")]
        public string AppBizId{ get; set; }

        /// <summary>
        /// Application type; knowledge_qa - knowledge Q&A management; summary - knowledge summary; classifys - knowledge label extraction.
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// Basic application configuration.
        /// </summary>
        [JsonProperty("BaseConfig")]
        public BaseConfig BaseConfig{ get; set; }

        /// <summary>
        /// Application configuration.
        /// </summary>
        [JsonProperty("AppConfig")]
        public AppConfig AppConfig{ get; set; }

        /// <summary>
        /// Login to user's sub-account (required in integrator mode).	
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppBizId", this.AppBizId);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamObj(map, prefix + "BaseConfig.", this.BaseConfig);
            this.SetParamObj(map, prefix + "AppConfig.", this.AppConfig);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
        }
    }
}

