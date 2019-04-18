/// <summary>
/// Root object for any script function used throughout the application
/// </summary>
var Todo02 = Todo02 || {};
Todo02.RootServer = "";        // Should be set to /vdir when deployed

/// <summary>
/// Return a root-based path
/// </summary>
Todo02.fromServer = function (relativeUrl) {
    return Todo01.RootServer + relativeUrl;
};


Todo02.post = function (url, data, success, error) {
    $.ajax({
        cache: false,
        url: Todo02.fromServer(url),
        type: 'post',
        data: data,
        success: success,
        error: error
    });
};