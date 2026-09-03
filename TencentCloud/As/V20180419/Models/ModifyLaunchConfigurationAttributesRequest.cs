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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLaunchConfigurationAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Launch configuration ID. You can obtain it by logging in to the <a href="https://console.cloud.tencent.com/autoscaling/config">console</a> or calling the <a href="https://www.tencentcloud.com/document/api/377/20445?from_cn_redirect=1">DescribeLaunchConfigurations</a> API, and retrieving LaunchConfigurationId from the returned information.</p>
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// <p>Specify a valid <a href="https://www.tencentcloud.com/document/product/213/4940?from_cn_redirect=1">image</a> ID, such as <code>img-8toqc6s3</code>. There are four image types:<br><li>Public image</li><li>Custom image</li><li>Shared image</li><li>Service market image</li><br>You can obtain an available image ID in the following ways:<br><li>For <code>public images</code>, <code>custom images</code>, and <code>shared images</code>, query the image ID by logging in to the <a href="https://console.cloud.tencent.com/cvm/image?rid=1&amp;imageType=PUBLIC_IMAGE">console</a>. For <code>service market images</code>, query the image ID in the <a href="https://market.cloud.tencent.com/list">cloud market</a>.</li><li>Call the <a href="https://www.tencentcloud.com/document/api/213/15715?from_cn_redirect=1">DescribeImages</a> API and take the <code>ImageId</code> field from the returned information.</li></p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>Types of CVM instances. Different instance models specify different resource specifications, and a maximum of 10 instance models are supported.<br>InstanceType specifies a single instance type. By setting InstanceTypes, you can specify multiple instance types and invalidate the original InstanceType. Specific values can be obtained by calling the API <a href="https://www.tencentcloud.com/document/api/213/15749?from_cn_redirect=1">DescribeInstanceTypeConfigs</a> to obtain the latest specification table or see <a href="https://www.tencentcloud.com/document/product/213/11518?from_cn_redirect=1">Instance Specifications</a>.</p>
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// <p>Instance type validation policy, effective during actual modification of InstanceTypes. Valid values include ALL and ANY, default value: ANY.</p><li>ALL: Verification passes if all InstanceTypes are available; otherwise, a verification error will be reported.</li> <li>ANY: Verification passes if any InstanceType is available; otherwise, a verification error will be reported.</li> Common causes of InstanceTypes unavailable include InstanceType sold out, corresponding cloud disk sold out. If a model in InstanceTypes does not exist or has been removed, a verification error will be reported regardless of the value of InstanceTypesCheckPolicy.
        /// </summary>
        [JsonProperty("InstanceTypesCheckPolicy")]
        public string InstanceTypesCheckPolicy{ get; set; }

        /// <summary>
        /// <p>Display name of the launch configuration. The name only supports Chinese, English, numbers, underscores, separator "-", and decimal points. The maximum length cannot exceed 60 bytes.</p>
        /// </summary>
        [JsonProperty("LaunchConfigurationName")]
        public string LaunchConfigurationName{ get; set; }

        /// <summary>
        /// <p>The custom data after Base64 encoding should not exceed 16 KB. To clear UserData, assign it an empty string.</p>
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// <p>Security group to which the instance belongs. You can obtain this parameter by calling the <a href="https://www.tencentcloud.com/document/api/215/15808?from_cn_redirect=1">DescribeSecurityGroups</a> API and getting the <code>SecurityGroupId</code> field in the return value.<br>If you specify this parameter, provide at least one security group, and the list order is sequential.</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>Public network bandwidth-related information settings.<br>When the public network outbound bandwidth cap is 0 Mbps, it cannot be modified to enable assigning public IP. Accordingly, when assigning public IP is currently enabled, the modified public network outbound bandwidth cap must be greater than 0 Mbps.</p>
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// <p>Instance billing type. Valid values:</p><li>POSTPAID_BY_HOUR: hourly postpaid</li><li>SPOTPAID: spot payment</li><li>PREPAID: prepaid, which is a Monthly Subscription</li><li>CDCPAID: dedicated cluster payment</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>Prepaid mode, that is, parameter settings related to monthly/annual subscription. By specifying this parameter, you can set attributes such as the duration of instance purchase and whether to enable auto-renewal.<br>If you change the payment mode of an instance to prepaid, this parameter is required. When changing from prepaid to other payment modes, the original info in this field is automatically discarded.<br>When adding this field, you must specify the duration of instance purchase. Other fields not specified will be set to default values.<br>When modifying this field, the current payment mode must be prepaid.</p>
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// <p>Market-related options of the instance, such as bidding instance parameters.<br>If you change the payment mode of the instance to spot payment, this parameter is required. When changing from spot payment to other payment modes, the original info in this field is automatically discarded.<br>When adding this field, you must transmit the bid price under relevant spot options. Other fields not transmitted will be set as default.<br>When modifying this field, the current payment mode must be spot payment.</p>
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptionsRequest InstanceMarketOptions{ get; set; }

        /// <summary>
        /// <p>Cloud disk type selection policy. Value range:</p><li>ORIGINAL: use the set cloud disk type.</li><li>AUTOMATIC: automatically select the currently available cloud disk type.</li>
        /// </summary>
        [JsonProperty("DiskTypePolicy")]
        public string DiskTypePolicy{ get; set; }

        /// <summary>
        /// <p>Instance system disk configuration information.</p>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// <p>Instance data disk configuration information.<br>Supports up to 11 data disks. Apply the modification as a whole, so provide all values after modification.<br>The data disk type is consistent with the system disk type by default.</p>
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// <p>Settings for the CVM host name.<br>Configuring the host name for windows instances is not supported.<br>When adding this attribute, you must transmit the CVM host name. Other fields not transmitted will be set to default values.<br>The host name (with the suffix added if it exists) is verified to check whether it exceeds the maximum length of 46 characters.</p>
        /// </summary>
        [JsonProperty("HostNameSettings")]
        public HostNameSettings HostNameSettings{ get; set; }

        /// <summary>
        /// <p>Settings related to the CVM instance name (InstanceName).<br>If the user sets this field in the launch configuration, the InstanceName of instances created by the scaling group will be set according to this field and transmitted to CVM. If the user does not set this field in the launch configuration, the InstanceName of instances created by the scaling group will be set as "as-{{ AutoScalingGroupName }}" and transmitted to CVM.<br>When adding this attribute, the CVM instance name must be transmitted. Other fields not transmitted will be set to default values.<br>It will verify whether the instance name (with the suffix added if it exists) exceeds the maximum length of 108 characters.</p>
        /// </summary>
        [JsonProperty("InstanceNameSettings")]
        public InstanceNameSettings InstanceNameSettings{ get; set; }

        /// <summary>
        /// <p>Enhanced service. This parameter can be used to specify whether to enable services such as cloud security and Cloud Monitor.</p>
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// <p>CAM role name, which can be obtained from the roleName in the return value from the <a href="https://www.tencentcloud.com/document/product/598/36223?from_cn_redirect=1">DescribeRoleList</a> API.</p>
        /// </summary>
        [JsonProperty("CamRoleName")]
        public string CamRoleName{ get; set; }

        /// <summary>
        /// <p>Hyper Computing Cluster ID. You can obtain this parameter by calling the <a href="https://www.tencentcloud.com/document/product/213/83220?from_cn_redirect=1">DescribeHpcClusters</a> API.<br>Note: This field is empty by default.</p>
        /// </summary>
        [JsonProperty("HpcClusterId")]
        public string HpcClusterId{ get; set; }

        /// <summary>
        /// <p>IPv6 public network bandwidth-related information settings. If the new instance includes an IPv6 address, this parameter can allocate public network bandwidth for the IPv6 address of the new instance. When the Ipv6AddressCount parameter of the scaling group associated with the launch configuration is 0, this parameter will not take effect.</p>
        /// </summary>
        [JsonProperty("IPv6InternetAccessible")]
        public IPv6InternetAccessible IPv6InternetAccessible{ get; set; }

        /// <summary>
        /// <p>Placement Group id. Only one can be specified. You can obtain this parameter by calling the <a href="https://www.tencentcloud.com/document/product/213/17810?from_cn_redirect=1">DescribeDisasterRecoverGroups</a> API.</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// <p>Instance login settings, including passwords, keys, or maintaining the image's original login settings.<br>Please note that specifying new login settings overwrites existing login settings. For example, if you previously used a password to login, use this parameter to change login settings to a key, and the original password is removed.</p>
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// <p>Instance tag list. By specifying this parameter, the instances added through scale-out can be bound to the tag. Up to 10 Tags can be specified.<br>This parameter overrides the original instance tag list. To add a tag, import both the new tag and the original tags.</p>
        /// </summary>
        [JsonProperty("InstanceTags")]
        public InstanceTag[] InstanceTags{ get; set; }

        /// <summary>
        /// <p>Image family name. You can obtain this parameter by calling the <a href="https://www.tencentcloud.com/document/product/213/15715?from_cn_redirect=1">DescribeImages</a> API.</p>
        /// </summary>
        [JsonProperty("ImageFamily")]
        public string ImageFamily{ get; set; }

        /// <summary>
        /// <p>Local exclusive cluster ID.</p>
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// <p>Custom metadata.</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public Metadata Metadata{ get; set; }

        /// <summary>
        /// <p>Replace the ENI configuration in the launch configuration.</p><p>Input limits: up to 17 items; must explicitly include and can only contain one PRIMARY. AS does not auto-complete the primary ENI. An explicit empty array is illegal.</p><p>Field rules match CreateLaunchConfiguration. To clean up, call ClearLaunchConfigurationAttributes with ClearNetworkInterfaces=true.</p>
        /// </summary>
        [JsonProperty("NetworkInterfaces")]
        public NetworkInterface[] NetworkInterfaces{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamSimple(map, prefix + "InstanceTypesCheckPolicy", this.InstanceTypesCheckPolicy);
            this.SetParamSimple(map, prefix + "LaunchConfigurationName", this.LaunchConfigurationName);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamObj(map, prefix + "InstanceMarketOptions.", this.InstanceMarketOptions);
            this.SetParamSimple(map, prefix + "DiskTypePolicy", this.DiskTypePolicy);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "HostNameSettings.", this.HostNameSettings);
            this.SetParamObj(map, prefix + "InstanceNameSettings.", this.InstanceNameSettings);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "CamRoleName", this.CamRoleName);
            this.SetParamSimple(map, prefix + "HpcClusterId", this.HpcClusterId);
            this.SetParamObj(map, prefix + "IPv6InternetAccessible.", this.IPv6InternetAccessible);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamArrayObj(map, prefix + "InstanceTags.", this.InstanceTags);
            this.SetParamSimple(map, prefix + "ImageFamily", this.ImageFamily);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamObj(map, prefix + "Metadata.", this.Metadata);
            this.SetParamArrayObj(map, prefix + "NetworkInterfaces.", this.NetworkInterfaces);
        }
    }
}

