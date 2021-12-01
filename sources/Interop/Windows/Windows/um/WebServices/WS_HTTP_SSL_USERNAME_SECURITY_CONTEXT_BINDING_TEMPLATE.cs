// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE"]/*' />
public partial struct WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE
{
    /// <include file='WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE.channelProperties"]/*' />
    public WS_CHANNEL_PROPERTIES channelProperties;

    /// <include file='WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE.securityProperties"]/*' />
    public WS_SECURITY_PROPERTIES securityProperties;

    /// <include file='WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE.sslTransportSecurityBinding"]/*' />
    public WS_SSL_TRANSPORT_SECURITY_BINDING_TEMPLATE sslTransportSecurityBinding;

    /// <include file='WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE.usernameMessageSecurityBinding"]/*' />
    public WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE usernameMessageSecurityBinding;

    /// <include file='WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_HTTP_SSL_USERNAME_SECURITY_CONTEXT_BINDING_TEMPLATE.securityContextSecurityBinding"]/*' />
    public WS_SECURITY_CONTEXT_SECURITY_BINDING_TEMPLATE securityContextSecurityBinding;
}
