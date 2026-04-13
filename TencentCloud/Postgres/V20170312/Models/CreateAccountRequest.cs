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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. can be obtained through the DescribeDBInstances api (https://www.tencentcloud.com/document/product/409/16773?lang=en).
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// The name of the account created. Consists of letters (a-z, A-Z), numbers (0-9), underscores (_), starts with a letter or (_), up to 63 characters. Cannot use system reserved keywords, cannot be postgres, and cannot begin with pg_or tencentdb_
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Account type. currently supported: normal, tencentDBSuper. normal references a general user, tencentDBSuper is an account that possesses the pg_tencentdb_superuser role.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Specifies the corresponding password for the account. the password rules are as follows:.
        /// <Li>Specifies a length of 8 to 32 characters. a password of more than 12 characters is recommended.</li>.
        /// <Li>Cannot start with "/".</li>.
        /// <Li>Specifies the following four items must be included.</li>.
        /// 
        /// Valid values: a to z (lowercase letters).           
        /// Uppercase letters: A - Z.
        /// Valid values: 0 - 9.
        /// Special symbols: ()`~!@#$%^&*-+=_|{}[]:<>,.?/.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Account remark. only allow english letters, digits, underscore, hyphen, and chinese characters, limited to 60 characters.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Specifies whether CAM verification is enabled for the account.
        /// </summary>
        [JsonProperty("OpenCam")]
        public bool? OpenCam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "OpenCam", this.OpenCam);
        }
    }
}

