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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeliveryCondition : AbstractModel
    {
        
        /// <summary>
        /// Log filter conditions. Detailed filter conditions are as follows:
        /// <li>EdgeResponseStatusCode: Filter by status code returned to the client by the EdgeOne node.<br>      Supported operators: equal, great, less, great_equal, less_equal<br>      Value range: Any integer greater than or equal to 0</li>
        /// <li>OriginResponseStatusCode: Filter by response status code of the origin server.<br>      Supported operators: equal, great, less, great_equal, less_equal<br>      Value range: Any integer greater than or equal to -1</li>
        /// <li>SecurityAction: Filter by final action after the request hits the security rule.<br>      Supported operators: equal<br>      Options are as follows:<br>      -: Unknown/unhit<br>      Monitor: Log only<br>      JSChallenge: JavaScript challenge<br>      Deny: Interception<br>      Allow: Allow<br>      BlockIP: IP ban<br>      Redirect: Redirect<br>      ReturnCustomPage: Return to custom page<br>      ManagedChallenge: Managed challenge<br>      Silence: Silence<br>      LongDelay: Response after a long wait<br>      ShortDelay: Response after a short wait</li>
        /// </summary>
        [JsonProperty("Conditions")]
        public QueryCondition[] Conditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
        }
    }
}

